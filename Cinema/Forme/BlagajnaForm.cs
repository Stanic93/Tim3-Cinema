﻿using Cinema.AttributeClass;
using Cinema.Controle;
using Cinema.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Forme
{
    public partial class BlagajnaForm : Form
    {
        PropertyInterface property = new RepertoarPropertyClass();
        ActiveTab activeTab;
        int filmID = 0;
        int racunID = 0;
        int zaposleniID = 0;
        string FullName = "";
        public BlagajnaForm(int zaposleniID, string imeIprezime)
        {
            InitializeComponent();
            OsnovnaPodesavanja();
            this.zaposleniID = zaposleniID;
            FullName = imeIprezime;

        }
        // osnovna podesavanja u rezimu repertoar
        public void OsnovnaPodesavanja()
        {
            dgvPregled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnNovaKarta.Text = "Karta";
            btnRezervacija.Text = "Rezervacija";
            lblStatusSale.Text = "";
            panel4.Visible = true;
            panel5.Visible = false;
            lblStatusSale.Visible = false;
            gbDetaljno.Enabled = true;
            dgvPregled.MultiSelect = false;
            btnRepertor.Enabled = true;
            panelPretraga.Visible = true;
            btnKarta.Enabled = false;
            btnRacun.Enabled = false;
            btnNovaKarta.Enabled = false;
            dtpDatumProdukcije.Enabled = false;
            toolStripKarta.Visible = false;
            btnPotvrdi.Visible = false;
            flpDetaljno.Dock = DockStyle.Fill;
            flpDetaljno.Controls.Clear();
            activeTab = ActiveTab.Repertoar;
            lblNazivFilma.Visible = false;
            lblZanrFilma.Visible = false;
            property = new RepertoarPropertyClass();
            popuniPregled(property);
            popuniControle(property);
            prikaziKolone();
        }

        // popunjava datagridView
        private void popuniPregled(PropertyInterface property)
        {
            PropertyInterface interfaceProperty = property;
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, interfaceProperty.GetSelectQuery());
            dt.Load(reader);
            reader.Close();
            dgvPregled.DataSource = null;
            dgvPregled.DataSource = dt;

            var type = interfaceProperty.GetType();
            var properties = type.GetProperties();
            foreach (DataGridViewColumn item in dgvPregled.Columns)
            {
                item.HeaderText = properties.Where(x => x.GetCustomAttributes<SqlNameAttribute>().FirstOrDefault().Naziv == item.HeaderText
                                      ).FirstOrDefault().GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName;
            }

        }

        // sakrivanje kolona koje nisu potrebne u dgv za tabove repertoar,karta,racun
        private void prikaziKolone()
        {
            if (activeTab == ActiveTab.Repertoar)
            {

                dgvPregled.Columns["FilmID"].Visible = false;
                dgvPregled.Columns["DatumPrvogPrikazivanja"].Visible = false;
                dgvPregled.Columns["DatumPosljednjegPrikazivanja"].Visible = false;
                dgvPregled.Columns["Aktivan"].Visible = false;
                dgvPregled.Columns["Reziser"].Visible = false;
                dgvPregled.Columns["Godina"].Width = 50;
                dgvPregled.Columns["Film"].Width = 145;
                return;
            }
            if (activeTab == ActiveTab.Karta)
            {
                dgvPregled.Columns["FilmID"].Visible = false;
                dgvPregled.Columns["ProjekcijaID"].Visible = false;
                dgvPregled.Columns["TerminID"].Visible = false;
            }
        }

        //popunjava flpDetaljno userControlama
        private void popuniControle(PropertyInterface property)
        {
            var properties = property.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                {
                    PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                        CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className)
                        as PropertyInterface;
                    UserLookUpControl ul;
                    int terminID = 4;
                    if (item.Name == "SjedisteID")
                    {
                         ul = new UserLookUpControl(foreignKeyInterface,terminID);
                    }
                    else
                         ul = new UserLookUpControl(foreignKeyInterface);
                    ul.Name = item.Name;
                    ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                    flpDetaljno.Controls.Add(ul);
                    continue;
                }

                if (item.GetCustomAttribute<VisibleAttribute>() != null)
                {
                    continue;
                }

                if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                {
                    RichTextBoxControl rc = new RichTextBoxControl();
                    rc.ReadOnly();
                    rc.Name = item.Name;
                    rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(rc);
                    continue;
                }
                if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl dc = new DateTimeControl();
                    dc.ReadOnly();
                    dc.Name = item.Name;
                    dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    dc.SetVrijednost("01.01.2018");
                    flpDetaljno.Controls.Add(dc);
                    continue;
                }

                if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    uc.ReadOnly();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }
            }
        }

        // klik na dataGridView
        private void dgvPregled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activeTab == ActiveTab.Karta)
            {
                btnNovaKarta.Enabled = true;
                setujKontroleKarta();
            }
            else
            {
                PopulatePropertyInterface(property);
                popuniDetaljno(property);
                setujGraniceDatumProdukcije(property);

                filmID = Convert.ToInt32(dgvPregled.SelectedRows[0].Cells[0].Value);
                lblNazivFilma.Text = dgvPregled.SelectedRows[0].Cells["Film"].Value.ToString();
                lblZanrFilma.Text = dgvPregled.SelectedRows[0].Cells["Zanr"].Value.ToString();
            }
            dtpDatumProdukcije.Enabled = true;
            btnNovaKarta.Enabled = true;
        }

        // popunjavanje property klasa u odgovarajuce tipove
        private void PopulatePropertyInterface(PropertyInterface property)
        {
            DataGridViewRow row = dgvPregled.SelectedRows[0];
            var properties = property.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                string value = row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Naziv]
                   .Value.ToString();
                // jer je podatak TimeSpan  u c# -> Time(7) u SQL
                if (item.GetCustomAttribute<SqlNameAttribute>().Naziv == "DuzinaTrajanja")
                {
                    TimeSpan time = TimeSpan.Parse(value);
                    item.SetValue(property, Convert.ChangeType(time, item.PropertyType));
                    continue;
                }
                if (value == "")
                {
                    value = "01.01.2018";
                }
                item.SetValue(property, Convert.ChangeType(value, item.PropertyType));
            }
        }

        // popunjava kontrole u flpDetaljno vrijednostima iz property.
        private void popuniDetaljno(PropertyInterface property)
        {
            var properties = property.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                foreach (var item2 in flpDetaljno.Controls)
                {
                    if (item2.GetType() == typeof(TextBoxControl))
                    {
                        TextBoxControl tbc = item2 as TextBoxControl;
                        if (tbc.Name == item.Name)
                        {
                            tbc.SetTextBox(item.GetValue(property).ToString());
                        }
                    }
                    if (item2.GetType() == typeof(RichTextBoxControl))
                    {
                        RichTextBoxControl tbc = item2 as RichTextBoxControl;
                        if (tbc.Name == item.Name)
                        {
                            tbc.SetVrijednost(item.GetValue(property).ToString());
                        }
                    }
                    if (item2.GetType() == typeof(DateTimeControl))
                    {
                        DateTimeControl tbc = item2 as DateTimeControl;
                        if (tbc.Name == item.Name)
                        {
                            tbc.SetVrijednost(item.GetValue(property).ToString());
                        }
                    }
                }
            }
        }

        //setuje granice datuma u rezimu Repertoar
        private void setujGraniceDatumProdukcije(PropertyInterface property)
        {
            DateTime dtMin = new DateTime(2018, 01, 01);
            DateTime dtMax = new DateTime(2018, 10, 01);

            string nesto = dgvPregled.SelectedRows[0].Cells["DatumPrvogPrikazivanja"].Value.ToString();

            if (dgvPregled.SelectedRows[0].Cells["DatumPrvogPrikazivanja"].Value.ToString() != "")
            {
                dtMin = Convert.ToDateTime(dgvPregled.SelectedRows[0].Cells["DatumPrvogPrikazivanja"].Value.ToString());
                dtMax = Convert.ToDateTime(dgvPregled.SelectedRows[0].Cells["DatumPosljednjegPrikazivanja"].Value.ToString());
            }

            if (dtMin > dtpDatumProdukcije.MaxDate)
            {

                dtpDatumProdukcije.MaxDate = dtMax;
                dtpDatumProdukcije.MinDate = dtMin;
            }
            else
            {
                dtpDatumProdukcije.MinDate = dtMin;
                dtpDatumProdukcije.MaxDate = dtMax;
            }

            dtpDatumProdukcije.Value = dtMin;



        }

        // dugme za pretraguFilmova , prikazi sve prikazuje sve aktivne filmove.
        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            popuniPregled(property);
        }

        // button za pretraguFilmova po nazivu.
        private void btnPretrazi_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = @"Select * from dbo.vRepertoar where Film Like '%'+@Naziv+'%'";
            command.Connection = connection;
            SqlParameter parameter = new SqlParameter("@Naziv", SqlDbType.NVarChar);
            parameter.Value = txtNaziv.Text;
            command.Parameters.Add(parameter);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                reader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection");
            }
            dgvPregled.DataSource = dt;

            prikaziKolone();
            txtNaziv.Text = "";
        }
        // txtPolje za pretragu
        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "" || txtNaziv.Text == " ")
            {
                btnPretrazi.Enabled = false;
            }
            else
            {
                btnPretrazi.Enabled = true;
            }
        }

        // klikom na novu kartu , postavlja se vrijednost button-a i mijenja se rezim rada.
        private void btnNovaKarta_Click(object sender, EventArgs e)
        {
            if (btnNovaKarta.Text == "Pregled racuna")
            {
                activeTab = ActiveTab.Racun;
            }
            else if (btnNovaKarta.Text == "Karta")
            {
                activeTab = ActiveTab.Karta;
                racunID = 0;
                btnRepertor.Enabled = false;
                lblNazivFilma.Visible = true;
                lblZanrFilma.Visible = true;
                btnRezervacija.Text = "Odustani";
                btnNovaKarta.Text = "Pregled racuna";
                btnKarta.Enabled = true;
                btnRacun.Enabled = false;
                btnNovaKarta.Enabled = true;
                dtpDatumProdukcije.Enabled = true;
                toolStripKarta.Visible = true;
                btnPotvrdi.Visible = true;
                flpDetaljno.Dock = DockStyle.None;
                panel4.Visible = false;
                panel5.Visible = true;
                txtNaziv.ReadOnly = true;
                txtNaziv.TextAlign = HorizontalAlignment.Center;
                gbDetaljno.Enabled = true;
                dgvPregled.DataSource = null;
                flpDetaljno.Controls.Clear();
                panelPretraga.Visible = false;
                gbPretraga.Text = "Info";
                tsbtnIzmjein.Visible = false;
                tsbtnObrisi.Visible = false;

                property = new KartaPropertyClass();
                popuniPregledProjekcija();
                popuniControle(property);
                if (dgvPregled.Rows.Count != 0)
                {
                    kreirajRacun();
                }

                property = new KartaPropertyClass();
                setujKontroleKarta();
            }

        }

        // kreiranje racuna prilikom klika na Karta.
        private void kreirajRacun()
        {
            property = new RacunPropertyClass();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, property.GetInsertQuery(), property.GetInsertParameters().ToArray());
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            RacunPropertyClass pomocni = property as RacunPropertyClass;
            reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, pomocni.GetMaxIDQuery());
            dt = new DataTable();

            dt.Load(reader);
            foreach (DataRow row in dt.Rows)
            {
                racunID = row.Field<short>("RacunID");
            }

            reader.Close();
        }

        // popunjavanje flpDetaljno kontrola u rezimu rada Karta
        private void setujKontroleKarta()
        {
            if (dgvPregled.Rows.Count == 0)
            {
                gbDetaljno.Enabled = false;
                btnNovaKarta.Enabled = false;
                lblStatusSale.Visible = true;
                lblStatusSale.Text = "Nema termina za prikazivanje";
                lblStatusSale.ForeColor = Color.Red;
                return;
            }
            foreach (var item in flpDetaljno.Controls)
            {
                if (item.GetType() == typeof(UserLookUpControl))
                {
                    UserLookUpControl ulup = item as UserLookUpControl;

                    if (ulup.Name == "ProjekcijaID")
                    {

                        ulup.Enabled = false;
                        ulup.SetKey(dgvPregled.SelectedRows[0].Cells["ProjekcijaID"].Value.ToString());
                        ulup.SetValue(dgvPregled.SelectedRows[0].Cells["ProjekcijaID"].Value.ToString());
                    }
                    if (ulup.Name == "TerminID")
                    {
                        ulup.Enabled = false;
                        ulup.SetKey(dgvPregled.SelectedRows[0].Cells["TerminID"].Value.ToString());
                        ulup.SetValue(dgvPregled.SelectedRows[0].Cells["VrijemePrikazivanja"].Value.ToString());
                    }
                    if (ulup.Name == "RacunID")
                    {

                        ulup.Enabled = false;
                        ulup.SetKey("" + racunID);
                        ulup.SetValue("" + racunID);
                    }
                }
                if (item.GetType() == typeof(TextBoxControl))
                {
                    TextBoxControl textBox = item as TextBoxControl;
                    if (textBox.Name == "VrijemeIzdavanja")
                    {
                        DateTime datum = DateTime.Now;
                        textBox.SetTextBox("" + datum);
                        textBox.ReadOnly();
                    }

                }
            }
        }
        // popunjavanje properties u  KartaPropertyClass
        private void populateKartaInterface()
        {

            var properties = property.GetType().GetProperties();
            string value = "";
            foreach (PropertyInfo item in properties)
            {
                value = "";
                if (item.Name == "KartaID")
                {
                    continue;
                }
                foreach (var item2 in flpDetaljno.Controls)
                {
                    if (item2.GetType() == typeof(UserLookUpControl))
                    {
                        UserLookUpControl ulup = item2 as UserLookUpControl;
                        if (ulup.Name == item.Name)
                        {
                            value = ulup.getKey();
                            if (ulup.Name == "SjedisteID" && value == "")
                            {
                                MessageBox.Show("Sjediste je obavezno!");
                                return;
                            }
                        }
                    }

                    if (item2.GetType() == typeof(TextBoxControl))
                    {
                        TextBoxControl textBox = item2 as TextBoxControl;
                        if (textBox.Name == item.Name)
                        {
                            value = textBox.GetTextBox();
                        }
                    }
                }
                if (item.GetCustomAttribute<SqlNameAttribute>().Naziv == "VrijemePrikazivanja")
                {
                    TimeSpan time = TimeSpan.Parse(value);
                    item.SetValue(property, Convert.ChangeType(time, item.PropertyType));
                    continue;
                }
                item.SetValue(property, Convert.ChangeType(value, item.PropertyType));

            }
        }
        // popunjavanje termina za odgovarajuci datum i film
        private void popuniPregledProjekcija()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = @"select * from vPregledProjekcije (@Date,@FilmID) order by VrijemePrikazivanja";
            SqlParameter parameter = new SqlParameter("@Date", SqlDbType.Date);
            SqlParameter parameter2 = new SqlParameter("@FilmID", SqlDbType.Int);
            parameter.Value = dtpDatumProdukcije.Value;
            parameter2.Value = filmID;
            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);

            command.Connection = connection;
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                reader.Close();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("Can not open connection");
            }
            dgvPregled.DataSource = dt;
            prikaziKolone();
        }
        // pomocni button za brisanje
        private void button2_Click(object sender, EventArgs e)
        {
            AdministracijaForm nova = new AdministracijaForm();
            nova.Show();
        }
        // prilikom promjene datumaProjekcije mijenja se dataGridView i prikazuju se drugi termini
        private void dtpDatumProdukcije_ValueChanged(object sender, EventArgs e)
        {
            if (activeTab == ActiveTab.Karta)
            {
                dgvPregled.DataSource = null;
                popuniPregledProjekcija();
            }
        }

        //kreiranje nove karte
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            populateKartaInterface();

            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, property.GetInsertQuery(), property.GetInsertParameters().ToArray());
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            foreach (var item in flpDetaljno.Controls)
            {
                if (item.GetType() == typeof(UserLookUpControl))
                {
                    UserLookUpControl ulup = item as UserLookUpControl;
                    if (ulup.Name == "SjedisteID")
                    {

                        ulup.SetKey("");
                        ulup.SetValue("");
                    }
                }
            }
            MessageBox.Show("Uspjesno ste dodali kartu na racun", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // klikom na btn rezervacija , koje ima rezim rada rezervisanja i odustajanja
        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            if (btnRezervacija.Text == "Odustani")
            {
                if(dgvPregled.Rows.Count == 0)
                {
                    OsnovnaPodesavanja();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Da li zelite da odustanete od racuna?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    OsnovnaPodesavanja();
                    IzbrisiKarteIRacun();
                }
            }
        }
        // brisanje karata i racuna (Klikom na odustani)
        private void IzbrisiKarteIRacun()
        {
            if(racunID == 0)
            {
                return;
            }
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = @"Delete
                                    from Karta
                                    where RacunID = @RacunID
                                    ";
            SqlCommand commandRacun = new SqlCommand();
            commandRacun.CommandText = @"Delete
                                    from Racun
                                    where RacunID = @RacunID
                                    ";
            commandRacun.Connection = connection;
            command.Connection = connection;
            SqlParameter parameter = new SqlParameter("@RacunID", SqlDbType.SmallInt);
            parameter.Value = racunID;
            command.Parameters.Add(parameter);
            SqlParameter parameterRacun = new SqlParameter("@RacunID", SqlDbType.SmallInt);
            parameterRacun.Value = racunID;
            commandRacun.Parameters.Add(parameterRacun);
            DataTable dt = new DataTable();
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                dt.Load(reader);
                command.Dispose();
                connection.Close();
                reader.Close();
                connection.Open();
                reader = commandRacun.ExecuteReader();
                dt.Load(reader);
                command.Dispose();
                connection.Close();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Can not open connection");
            }

        }
    }
}

