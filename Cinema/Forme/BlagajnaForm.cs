using Cinema.AttributeClass;
using Cinema.Controle;
using Cinema.PropertyClass;
using Microsoft.VisualBasic;
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
        int terminID = 0;
        string FullName = "";
        State state = State.Idle;
        string ImeRezervacije = "";
        string rezervacijaID = "";

        public BlagajnaForm(int zaposleniID, string imeIprezime)
        {
            InitializeComponent();
            OsnovnaPodesavanja();
            this.zaposleniID = zaposleniID;
            FullName = imeIprezime;
            lblKorisnickoIme.Text = FullName;
            lblRadnik.Visible = false;
            dgvPregled.MultiSelect = false;
            dgvPregled.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPregled.RowHeadersVisible = false;
            dgvPregled.AllowUserToResizeColumns = false;
            dgvPregled.AllowUserToResizeRows = false;
            timer1.Start();

        }

        // osnovna podesavanja u rezimu repertoar
        public void OsnovnaPodesavanja()
        {
            dgvPregled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPregled.DefaultCellStyle.SelectionBackColor = Color.Orange;
            state = State.Idle;
            dtpDatumProdukcije.Visible = true;
            lblDatumProdukcije.Visible = true;
            btnRezervacija.Enabled = false;
            btnDodajRezervaciju.Visible = false;
            btnNovaKarta.Text = "Karta";
            btnRezervacija.Text = "Rezervacija";
            lblStatusSale.Text = "";
            lblStatusSale.Visible = false;
            gbDetaljno.Enabled = true;
            btnVratiNaKartu.Visible = false;
            btnOdustaniRacun.Visible = false;
            btnTabRepertoar.Enabled = true;
            panelPretraga.Visible = true;
            btnTabKarta.Enabled = false;
            btnTabRacun.Enabled = false;
            btnTabRezervacija.Enabled = false;
            btnNovaKarta.Enabled = false;
            dtpDatumProdukcije.Enabled = false;
            lblDatumProdukcije.Visible = true;
            dtpDatumProdukcije.Visible = true;
            panelToolStrip.Visible = false;
            btnPotvrdi.Visible = false;
            flpDetaljno.Dock = DockStyle.Fill;
            flpDetaljno.Controls.Clear();
            activeTab = ActiveTab.Repertoar;
            btnTabRepertoar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnTabRepertoar.FlatAppearance.BorderSize = 1;
            btnTabRacun.FlatAppearance.BorderSize = 0;
            btnTabRezervacija.FlatAppearance.BorderSize = 0;
            btnTabKarta.FlatAppearance.BorderSize = 0;
            lblNazivFilma.Visible = false;
            lblZanrFilma.Visible = false;
            panelRacun.Visible = false;
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

                return;
            }
            if (activeTab == ActiveTab.Karta || activeTab == ActiveTab.Rezervacija)
            {
                dgvPregled.Columns["FilmID"].Visible = false;
                dgvPregled.Columns["ProjekcijaID"].Visible = false;
                dgvPregled.Columns["TerminID"].Visible = false;
            }
            if (activeTab == ActiveTab.Racun)
            {
                dgvPregled.Columns["ProjekcijaID"].Visible = false;
                dgvPregled.Columns["TerminID"].Visible = false;
                dgvPregled.Columns["SjedisteID"].Visible = false;
            }
        }

        //popunjava flpDetaljno userControlama
        private void popuniControle(PropertyInterface property)
        {
            flpDetaljno.Controls.Clear();
            var properties = property.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                if (item.Name == "RezervacijaID")
                {
                    continue;
                }
                if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                {
                    PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                        CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className)
                        as PropertyInterface;
                    UserLookUpControl ul;

                    if (activeTab == ActiveTab.Karta || activeTab == ActiveTab.Racun || activeTab == ActiveTab.Rezervacija)
                    {

                        if (activeTab == ActiveTab.Karta || activeTab == ActiveTab.Rezervacija)
                        {
                            if (dgvPregled.SelectedRows.Count != 0)
                            {
                                terminID = Convert.ToInt32(dgvPregled.SelectedRows[0].Cells[0].Value.ToString());
                            }
                        }
                        if (item.Name == "SjedisteID")
                        {
                            ul = new UserLookUpControl(foreignKeyInterface, terminID);
                        }
                        else
                            ul = new UserLookUpControl(foreignKeyInterface);
                        ul.Name = item.Name;
                        ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                        flpDetaljno.Controls.Add(ul);
                        continue;
                    }
                }

                if (item.GetCustomAttribute<VisibleAttribute>() != null)
                {
                    continue;
                }

                if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                {
                    RichTextBoxControl rc = new RichTextBoxControl();
                    rc.Zabrani();
                    rc.Name = item.Name;
                    rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(rc);
                    continue;
                }
                if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl dc = new DateTimeControl();
                    dc.Zabrani();
                    dc.Name = item.Name;
                    dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    dc.SetVrijednost("01.01.2018");
                    flpDetaljno.Controls.Add(dc);
                    continue;
                }

                if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    uc.Zabrani();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }
            }
        }

        // klik na dataGridView
        private void dgvPregled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (activeTab == ActiveTab.Karta || activeTab == ActiveTab.Rezervacija)
            {
                if (activeTab != ActiveTab.Rezervacija)
                {
                    btnNovaKarta.Enabled = true;
                }
                flpDetaljno.Controls.Clear();
                popuniControle(property);
                setujKontroleKarta();
            }
            if (activeTab == ActiveTab.Repertoar)
            {
                PopulatePropertyInterface(property);
                popuniDetaljno(property);
                setujGraniceDatumProdukcije(property);
                btnRezervacija.Enabled = true;

                filmID = Convert.ToInt32(dgvPregled.SelectedRows[0].Cells[0].Value);
                lblNazivFilma.Text = dgvPregled.SelectedRows[0].Cells["Film"].Value.ToString();
                lblZanrFilma.Text = dgvPregled.SelectedRows[0].Cells["Zanr"].Value.ToString();
            }
            if (activeTab == ActiveTab.Racun)
            {
                setujKontroleKarta();
            }
            dtpDatumProdukcije.Enabled = true;
            if (activeTab != ActiveTab.Rezervacija)
            {
                btnNovaKarta.Enabled = true;
            }
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

        // txtPolje za pretragu
        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, property.GetSearchQuery(txtNaziv.Text));

            dt.Load(reader);
            reader.Close();
            dgvPregled.DataSource = dt;
            prikaziKolone();
        }

        // klikom na novu kartu , postavlja se vrijednost button-a i mijenja se rezim rada.
        private void btnNovaKarta_Click(object sender, EventArgs e)
        {
            if (btnNovaKarta.Text == "Pregled racuna")
            {
                activeTab = ActiveTab.Racun;
                btnNovaKarta.Text = "Stampaj";
                panelToolStrip.Visible = true;
                flpDetaljno.Controls.Clear();
                dgvPregled.DataSource = null;
                txtZaposleni.Text = FullName;
                txtZaposleni.ReadOnly = true;
                panelRacun.Visible = true;
                btnTabKarta.Enabled = false;
                btnTabRacun.Enabled = true;
                btnDodajRezervaciju.Visible = false;
                btnPotvrdi.Visible = false;
                lblDatumProdukcije.Visible = false;
                dtpDatumProdukcije.Visible = false;
                btnTabRezervacija.Enabled = false;

                btnTabRacun.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                btnTabRacun.FlatAppearance.BorderSize = 1;
                btnTabRepertoar.FlatAppearance.BorderSize = 0;
                btnTabRezervacija.FlatAppearance.BorderSize = 0;
                btnTabKarta.FlatAppearance.BorderSize = 0;
                popuniPregledRacun();
                if (dgvPregled.Rows.Count == 0)
                {
                    tsbtnDodaj.Enabled = true;
                    tsbtnIzmijeni.Visible = false;
                    tsbtnObrisi.Visible = false;
                }
                else
                {
                    panelToolStrip.Enabled = true;
                    tsbtnDodaj.Enabled = true;
                    tsbtnIzmijeni.Visible = true;
                    tsbtnObrisi.Visible = true;
                }
                IzracunajSumuRacuna();
                popuniControle(property);
                setujKontroleKarta();
                gbDetaljno.Enabled = false;
            }
            else if (btnNovaKarta.Text == "Karta")
            {
                if (activeTab != ActiveTab.Rezervacija)
                {
                    activeTab = ActiveTab.Karta;
                    btnTabRepertoar.Enabled = false;
                    btnRezervacija.Text = "Odustani";
                    btnNovaKarta.Text = "Pregled racuna";
                    btnTabKarta.Enabled = true;
                    btnTabRacun.Enabled = false;
                    btnTabRezervacija.Enabled = false;
                    btnNovaKarta.Enabled = true;
                    btnVratiNaKartu.Visible = false;
                    btnTabKarta.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                    btnTabKarta.FlatAppearance.BorderSize = 1;
                    btnTabRepertoar.FlatAppearance.BorderSize = 0;
                    btnTabRezervacija.FlatAppearance.BorderSize = 0;
                    btnTabRacun.FlatAppearance.BorderSize = 0;
                }
                else
                {
                    btnTabKarta.Enabled = false;
                    btnTabRacun.Enabled = false;
                    btnTabRepertoar.Enabled = false;
                    btnTabRezervacija.Enabled = true;
                    btnRezervacija.Text = "Odustani";
                    btnNovaKarta.Text = "Potvrdi rezervaciju";
                    btnNovaKarta.Enabled = false;
                    btnVratiNaKartu.Text = "Pregled rezervacija";
                    btnVratiNaKartu.Visible = true;
                    btnTabRezervacija.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
                    btnTabRezervacija.FlatAppearance.BorderSize = 1;
                    btnTabRepertoar.FlatAppearance.BorderSize = 0;
                    btnTabRacun.FlatAppearance.BorderSize = 0;
                    btnTabKarta.FlatAppearance.BorderSize = 0;
                }
                lblDatumProdukcije.Visible = true;
                dtpDatumProdukcije.Visible = true;
                if (state == State.Idle)
                {
                    racunID = 0;
                }
                lblNazivFilma.Visible = true;
                lblZanrFilma.Visible = true;
                dtpDatumProdukcije.Enabled = true;
                panelToolStrip.Visible = false;
                btnPotvrdi.Visible = true;
                flpDetaljno.Dock = DockStyle.None;
                gbDetaljno.Enabled = true;
                dgvPregled.DataSource = null;
                flpDetaljno.Controls.Clear();
                panelPretraga.Visible = false;
                gbPretraga.Text = "Info";
                property = new KartaPropertyClass();
                popuniPregledProjekcija();
                if (dgvPregled.Rows.Count > 0)
                {
                    panelToolStrip.Enabled = true;
                    if (activeTab == ActiveTab.Rezervacija)
                    {
                        btnDodajRezervaciju.Visible = true;
                        btnDodajRezervaciju.Enabled = true;
                    }
                }
                else
                {
                    panelToolStrip.Enabled = false;
                    if (activeTab == ActiveTab.Rezervacija)
                    {
                        btnDodajRezervaciju.Visible = true;
                        btnDodajRezervaciju.Enabled = false;
                    }
                }
                popuniControle(property);
                if (activeTab != ActiveTab.Rezervacija)
                {
                    if (state == State.Idle)
                    {
                        kreirajRacun();
                    }
                }
                property = new KartaPropertyClass();
                setujKontroleKarta();
            }
            else if (btnNovaKarta.Text == "Stampaj")
            {
                state = State.Idle;
                OsnovnaPodesavanja();
            }
            else if (btnNovaKarta.Text == "Potvrdi rezervaciju")
            {
                MessageBox.Show("Rezervacija uspjesno kreirana!");
                rezervacijaID = "";
                ImeRezervacije = "";
                OsnovnaPodesavanja();
            }
        }

        // kreiranje racuna prilikom klika na Karta.
        private void kreirajRacun()
        {
            property = new RacunPropertyClass();
            string command = @"INSERT into dbo.Racun (DatumIzdavanja, ZaposleniID, UkupnaCijena) values (GetDate(), @ZaposleniID, null)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ZaposleniID", SqlDbType.SmallInt);
                parameter.Value = zaposleniID;
                parameters.Add(parameter);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(command, parameters);
            RacunPropertyClass pomocni = property as RacunPropertyClass;
            SqlDataReader reader1 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, pomocni.GetMaxIDQuery());
            DataTable dt1 = new DataTable();

            dt1.Load(reader1);
            foreach (DataRow row in dt1.Rows)
            {
                racunID = row.Field<short>("RacunID");
            }
            reader1.Close();
        }

        // popunjavanje flpDetaljno kontrola u rezimu rada Karta
        private void setujKontroleKarta()
        {
            if (dgvPregled.Rows.Count == 0)
            {
                if (activeTab != ActiveTab.Racun)
                {
                    gbDetaljno.Enabled = false;
                    btnNovaKarta.Enabled = false;
                    lblStatusSale.Visible = true;
                    lblStatusSale.Text = "Nema termina za prikazivanje";
                    lblStatusSale.ForeColor = Color.Red;
                    btnVratiNaKartu.Visible = false;
                    btnDodajRezervaciju.Visible = false;
                }
                else
                {
                    btnNovaKarta.Enabled = false;
                }
                return;
            }
            else
            {
                if (activeTab == ActiveTab.Karta)
                {
                    gbDetaljno.Enabled = true;
                }
                else
                {
                    gbDetaljno.Enabled = false;
                }
                if (activeTab != ActiveTab.Rezervacija)
                {
                    btnNovaKarta.Enabled = true;
                }
                else
                {
                    btnDodajRezervaciju.Visible = true;
                    btnVratiNaKartu.Visible = true;
                }
                lblStatusSale.Visible = false;
                lblStatusSale.Text = "";
            }
            foreach (var item in flpDetaljno.Controls)
            {
                if (item.GetType() == typeof(UserLookUpControl))
                {
                    UserLookUpControl ulup = item as UserLookUpControl;

                    if (ulup.Name == "ProjekcijaID")
                    {
                        ulup.Zakljucaj();
                        ulup.SetKey(dgvPregled.SelectedRows[0].Cells["ProjekcijaID"].Value.ToString());
                        ulup.SetValue(lblNazivFilma.Text);
                    }
                    if (ulup.Name == "TerminID")
                    {
                        ulup.Zakljucaj();
                        ulup.SetKey(dgvPregled.SelectedRows[0].Cells["TerminID"].Value.ToString());
                        ulup.SetValue(dgvPregled.SelectedRows[0].Cells["Vrijeme prikazivanja"].Value.ToString());
                    }
                    if (activeTab == ActiveTab.Racun)
                    {
                        if (ulup.Name == "SjedisteID")
                        {
                            ulup.SetKey(dgvPregled.SelectedRows[0].Cells["SjedisteID"].Value.ToString());
                            ulup.SetValue(dgvPregled.SelectedRows[0].Cells["Broj sjedista"].Value.ToString());
                        }
                    }

                    if (ulup.Name == "RacunID")
                    {
                        ulup.Zakljucaj();
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
                        textBox.Zabrani();
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
                if (state != State.Delete)
                {
                    if (item.Name == "KartaID")
                    {
                        continue;
                    }
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
                if (item.Name != "RezervacijaID")
                {
                    item.SetValue(property, Convert.ChangeType(value, item.PropertyType));
                }
                else
                {
                    if (activeTab == ActiveTab.Rezervacija)
                    {
                        if (item.Name == "RezervacijaID")
                        {
                            item.SetValue(property, Convert.ChangeType(rezervacijaID, item.PropertyType));
                        }
                    }
                }
            }
        }

        // popunjavanje termina za odgovarajuci datum i film
        private void popuniPregledProjekcija()
        {
            DataTable dt = new DataTable();
            string command = @"exec proc_PregledProjekcije @Date,@FilmID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("@Date", SqlDbType.Date);
            SqlParameter parameter2 = new SqlParameter("@FilmID", SqlDbType.Int);
            parameter.Value = dtpDatumProdukcije.Value;
            parameter2.Value = filmID;
            parameters.Add(parameter);
            parameters.Add(parameter2);
            dt = Izvrsi(command, parameters);
            dgvPregled.DataSource = null;
            dgvPregled.DataSource = dt;
            prikaziKolone();
        }

        // prilikom promjene datumaProjekcije mijenja se dataGridView i prikazuju se drugi termini
        private void dtpDatumProdukcije_ValueChanged(object sender, EventArgs e)
        {
            if (activeTab == ActiveTab.Karta || activeTab == ActiveTab.Rezervacija)
            {
                dgvPregled.DataSource = null;
                popuniPregledProjekcija();
                popuniControle(property);
                setujKontroleKarta();
            }
        }

        //kreiranje nove karte
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            foreach (var item in flpDetaljno.Controls)
            {
                if (item.GetType() == typeof(UserLookUpControl))
                {
                    UserLookUpControl ulup = item as UserLookUpControl;
                    if (ulup.Name == "SjedisteID")
                    {
                        string key = ulup.getKey();
                        if (key == "" || key == " ")
                        {
                            MessageBox.Show("Popunite broj sjedista");
                            return;
                        }


                    }
                }
            }
            if (activeTab == ActiveTab.Karta)
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
            else if (activeTab == ActiveTab.Rezervacija)
            {
                populateKartaInterface();
                KartaPropertyClass novi = property as KartaPropertyClass;
                SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, novi.GetInsertRezervacijaQuery(), novi.GetInsertRezervacijaParameters().ToArray());
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
                MessageBox.Show("Uspjesno ste rezervisali kartu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovaKarta.Enabled = true;
            }
            else if (activeTab == ActiveTab.Racun)
            {
                gbDetaljno.Enabled = false;
                string command = @"Update Karta Set SjedisteID = @SjedisteID where KartaID = @KartaID";
                List<SqlParameter> parameters = new List<SqlParameter>();
                SqlParameter parameter = new SqlParameter("@KartaID", SqlDbType.SmallInt);
                SqlParameter parameter2 = new SqlParameter("@SjedisteID", SqlDbType.SmallInt);
                string vrijednost = "";
                foreach (var item2 in flpDetaljno.Controls)
                {
                    if (item2.GetType() == typeof(UserLookUpControl))
                    {
                        UserLookUpControl tbc = item2 as UserLookUpControl;
                        if (tbc.Name == "SjedisteID")
                        {
                            vrijednost = tbc.getKey();
                        }
                    }
                }
                parameter2.Value = Convert.ToInt16(vrijednost);
                short broj = Convert.ToInt16(dgvPregled.SelectedRows[0].Cells[0].Value.ToString());
                parameter.Value = broj;
                parameters.Add(parameter);
                parameters.Add(parameter2);
                DataTable dt = new DataTable();
                dt = Izvrsi(command, parameters);
                popuniPregledRacun();
                state = State.Idle;
                gbDetaljno.Enabled = false;
                btnOdustaniRacun.Visible = false;
                btnPotvrdi.Visible = false;
                gbPregled.Enabled = true;
                panelRacun.Enabled = true;
                gbKarta.Enabled = true;
                gbPretraga.Enabled = true;
            }
        }

        // klikom na btn rezervacija , koje ima rezim rada rezervisanja i odustajanja
        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            if (btnRezervacija.Text == "Odustani")
            {
                if (activeTab != ActiveTab.Rezervacija)
                {
                    DialogResult dialogResult = MessageBox.Show("Da li zelite da odustanete od racuna?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        IzbrisiKarteIRacun();
                        OsnovnaPodesavanja();
                        state = State.Idle;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Da li zelite da odustanete od rezervacije?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        IzbrisiKarteiRezervaciju();
                        OsnovnaPodesavanja();
                        state = State.Idle;
                    }
                }
            }
            else if (btnRezervacija.Text == "Rezervacija")
            {
                activeTab = ActiveTab.Rezervacija;
                btnNovaKarta_Click(sender, e);
                gbKarta.Enabled = true;
                btnNovaKarta.Enabled = false;
                gbPretraga.Enabled = true;
                btnDodajRezervaciju.Enabled = true;
            }
        }

        // brisanje karata i racuna (Klikom na odustani)
        private void IzbrisiKarteIRacun()
        {
            if (racunID == 0)
            {
                return;
            }
            string commandDeleteKarta = @"Delete
                                    from Karta
                                    where RacunID = @RacunID
                                    ";
            string commandDeleteRacun = @"Delete
                                    from Racun
                                    where RacunID = @RacunID
                                    ";
            List<SqlParameter> parametersKarta = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RacunID", SqlDbType.SmallInt);
                parameter.Value = racunID;
                parametersKarta.Add(parameter);
            }
            List<SqlParameter> parametersRacun = new List<SqlParameter>();
            {
                SqlParameter parameterRacun = new SqlParameter("@RacunID", SqlDbType.SmallInt);
                parameterRacun.Value = racunID;
                parametersRacun.Add(parameterRacun);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(commandDeleteKarta, parametersKarta);
            dt = Izvrsi(commandDeleteRacun, parametersRacun);
        }

        // brisanje karata i rezervacije(klikom na odustani)
        private void IzbrisiKarteiRezervaciju()
        {
            if (rezervacijaID == "")
            {
                return;
            }
            string commandDeleteKarta = @"Delete
                                    from Karta
                                    where RezervacijaID = @RezervacijaID
                                    ";
            string commandRacun = @"Delete
                                    from Rezervacija
                                    where RezervacijaID = @RezervacijaID
                                    ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = rezervacijaID;
                parameters.Add(parameter);
            }
            List<SqlParameter> parametersRezervacija = new List<SqlParameter>();
            {
                SqlParameter parametarRezervacija = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parametarRezervacija.Value = rezervacijaID;
                parametersRezervacija.Add(parametarRezervacija);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(commandDeleteKarta, parameters);
            dt.Clear();
            dt = Izvrsi(commandRacun, parametersRezervacija);
        }

        // kreiranje prikaza karata na racunu ()
        private void popuniPregledRacun()
        {
            dgvPregled.DataSource = null;
            DataTable dt = new DataTable();
            string command = @"exec proc_PregledRacuna @RacunID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RacunID", SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            dt = Izvrsi(command, parameters);
            dgvPregled.DataSource = dt;
            prikaziKolone();
        }

        // kreiranje sume za racun
        private void IzracunajSumuRacuna()
        {
            decimal cijena = 0;
            foreach (DataGridViewRow row in dgvPregled.Rows)
            {
                string cijenaPolje = row.Cells["Cijena"].Value.ToString();
                cijena += Convert.ToDecimal(cijenaPolje);
            }
            txtUkupnaVrijednost.Text = "" + cijena;
            txtUkupnaVrijednost.ReadOnly = true;
        }

        private void btnVratiNaKartu_Click(object sender, EventArgs e)
        {
            RezervacijaForm novaForma = new RezervacijaForm(terminID, lblNazivFilma.Text, dgvPregled.SelectedRows[0].Cells["Vrijeme prikazivanja"].Value.ToString(), zaposleniID, FullName);
            novaForma.ShowDialog();
        }

        private void tsbtnObrisi_Click(object sender, EventArgs e)
        {

            if (dgvPregled.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvPregled.SelectedRows[0];
                state = State.Delete;
                gbDetaljno.Enabled = false;
                string command = @"Delete from Karta where KartaID = @KartaID";
                List<SqlParameter> parameters = new List<SqlParameter>();
                {
                    SqlParameter parameter = new SqlParameter("@KartaID", SqlDbType.SmallInt);
                    short broj = Convert.ToInt16(row.Cells[0].Value.ToString());
                    parameter.Value = broj;
                    parameters.Add(parameter);
                }
                DataTable dt = new DataTable();
                dt = Izvrsi(command, parameters);
                popuniPregledRacun();
                IzracunajSumuRacuna();
                if (dgvPregled.SelectedRows.Count == 0)
                {
                    btnNovaKarta.Enabled = false;
                    tsbtnDodaj.Enabled = true;
                    tsbtnIzmijeni.Visible = false;
                    tsbtnObrisi.Visible = false;
                    flpDetaljno.Controls.Clear();
                }
                else
                {
                    tsbtnIzmijeni.Visible = true;
                    tsbtnObrisi.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Nije selektovana karta");
            }
        }

        private void tsbtnIzmjein_Click(object sender, EventArgs e)
        {
            state = State.Edit;
            gbDetaljno.Enabled = true;
            btnOdustaniRacun.Visible = true;
            btnPotvrdi.Visible = true;
            gbPregled.Enabled = false;
            panelRacun.Enabled = false;
            gbKarta.Enabled = false;
            gbPretraga.Enabled = false;
        }

        private void btnOdustaniRacun_Click(object sender, EventArgs e)
        {
            state = State.Idle;
            gbDetaljno.Enabled = false;
            btnOdustaniRacun.Visible = false;
            btnPotvrdi.Visible = false;
            gbPregled.Enabled = true;
            panelRacun.Enabled = true;
            gbKarta.Enabled = true;
            if (activeTab == ActiveTab.Rezervacija)
            {
                gbPretraga.Enabled = false;
            }
            else
            {
                gbPretraga.Enabled = true;
            }
            panelPregledRacuna.Enabled = true;
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            bool prosao = true;
            do
            {
                string input = "";
                DialogResult dialog = ShowInputDialog(ref input);

                if (dialog == DialogResult.OK)
                {
                    if (input == "" || input == " ")
                    {
                        MessageBox.Show("Naziv rezervacije mora biti unesen!");
                    }
                    else
                    {
                        if (provjeriImeRezervacije(input))
                        {
                            ImeRezervacije = input;
                            dodajRezervaciju(input);
                            panelPregledRacuna.Enabled = false;
                            gbPretraga.Enabled = false;
                            gbDetaljno.Enabled = true;
                            btnPotvrdi.Visible = true;
                            btnOdustaniRacun.Visible = true;
                            gbKarta.Enabled = true;
                            prosao = false;
                        }
                    }
                }
                else
                {
                    prosao = false;
                }
            } while (prosao);
            setujRezervacijaId();
            dtpDatumProdukcije.Visible = false;
            lblDatumProdukcije.Visible = false;
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Naziv rezervacije";
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void dodajRezervaciju(string imeRezervacije)
        {
            string command = @"Insert into Rezervacija (RezervacijaNaIme) values (@ImeRezervacije)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ImeRezervacije", SqlDbType.NVarChar);
                parameter.Value = imeRezervacije;
                parameters.Add(parameter);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(command, parameters);
        }

        private bool provjeriImeRezervacije(string imeRezervacije)
        {
            string command = @"Select Distinct r.RezervacijaNaIme
                                        from Karta as k
                                        join Rezervacija as r
	                                            on k.RezervacijaID = r.RezervacijaID
                                        where (k.RezervacijaID is not null) and (TerminID = @TerminID) and r.RezervacijaNaIme = @Rezervacija";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@TerminID", SqlDbType.SmallInt);
                short broj = Convert.ToInt16(dgvPregled.SelectedRows[0].Cells["TerminID"].Value.ToString());
                parameter.Value = broj;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter2 = new SqlParameter("@Rezervacija", SqlDbType.NVarChar);
                parameter2.Value = imeRezervacije;
                parameters.Add(parameter2);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(command, parameters);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Naziv rezervacije zauzet!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void setujRezervacijaId()
        {
            string command = @"Select RezervacijaID
                                    from dbo.Rezervacija";
            DataTable dt = new DataTable();
            List<SqlParameter> parameters = new List<SqlParameter>();
            dt = Izvrsi(command, parameters);
            DataRow dr = dt.Rows[dt.Rows.Count - 1];
            rezervacijaID = Convert.ToString(dr.Field<short>(0));
        }

        private void tsbtnDodaj_Click(object sender, EventArgs e)
        {
            btnNovaKarta.Text = "Karta";
            panelRacun.Visible = false;
            state = State.Add;
            btnNovaKarta_Click(sender, e);
        }

        private void dgvPregled_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvPregled.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dgvPregled.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 128);
                }
            }
        }

        private DataTable Izvrsi(string commandText, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = connection;
            if (parameters.Count > 0)
            {
                for (int i = 0; i < parameters.Count; i++)
                {
                    command.Parameters.Add(parameters[i]);
                }
            }
            SqlDataReader reader;
            DataTable dt = new DataTable();
          //  try
           // {
                connection.Open();
                reader = command.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                reader.Close();
                command.Dispose();
          /*  }
            catch
            {
                MessageBox.Show("Can not open connection");
            }*/
            return dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

