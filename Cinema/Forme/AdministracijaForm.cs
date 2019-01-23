using Cinema.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Cinema.AttributeClass;
using Cinema.Controle;
using System.Text.RegularExpressions;

namespace Cinema.Forme
{
    public partial class AdministracijaForm : Form
    {
        StateEnum state = StateEnum.Preview;
        PropertyInterface property = new ZaposleniPropertyClass();
        // ActiveTab activeTab;
        public AdministracijaForm(string ime)
        {
            InitializeComponent();
            btnZaposleni.Click += Btn_Click;
            btnZanr.Click += Btn_Click;
            btnProjekcija.Click += Btn_Click;
            btnLogin.Click += Btn_Click;
            btnFilm.Click += Btn_Click;
            lblKorisnickoIme.Text = ime;
            lblPretraga.Text = "Pretraga po imenu/prezimenu zaposlenog";
            btnZaposleni.Click += BtnOboji_Click;
            btnFilm.Click += BtnOboji_Click;
            btnTermini.Click += BtnOboji_Click;
            btnProjekcija.Click += BtnOboji_Click;
            btnZanr.Click += BtnOboji_Click;
            btnLogin.Click += BtnOboji_Click;
            btnZaposleni.FlatAppearance.BorderColor = Color.Orange;
            btnZaposleni.FlatAppearance.BorderSize = 1;
            //timer1.Start();
            //lblSat.Text = DateTime.Now.ToShortTimeString();// umjesto ovog tajmer dodati i startovat ga
            timer2.Start();
            OsnovnaPodesavanja();


            #region PocetnoUcitavanjaDataGrid
            UcitajDGV(property);
            #endregion
        }

        private void BtnOboji_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 4; i < panelMeni.Controls.Count; i++)
            {
                if (panelMeni.Controls[i].GetType() == typeof(Button))
                {
                    Button pom = panelMeni.Controls[i] as Button;
                    pom.FlatAppearance.BorderColor = Color.FromArgb(52, 52, 52);
                }
                else
                {
                    continue;
                }

            };
            btn.FlatAppearance.BorderColor = Color.Orange;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void PonistiBoje()
        {
            for (int i = 4; i < panelMeni.Controls.Count; i++)
            {
                if (panelMeni.Controls[i].GetType() == typeof(Button))
                {
                    Button pom = panelMeni.Controls[i] as Button;
                    pom.FlatAppearance.BorderColor = Color.FromArgb(52, 52, 52);
                }
            }
            tsbtnAdd.FlatAppearance.BorderSize = 0;
            tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
        }

        public void OsnovnaPodesavanja()
        {
            dgvPrikaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrikaz.MultiSelect = false;
            dgvPrikaz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrikaz.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPrikaz.DefaultCellStyle.SelectionBackColor = Color.Orange;
            dgvPrikaz.RowHeadersVisible = false;
            dgvPrikaz.AllowUserToResizeColumns = false;
            dgvPrikaz.AllowUserToResizeRows = false;

            postaviControle(property);


        }
        //ucitava dataGridView tabelom zavisno od tog na koji od menija je kliknuto
        private void Btn_Click(object sender, EventArgs e)
        {
            
            if (btnFilm == sender as Button || pbFilm == sender as PictureBox)
            {
                property = new FilmPropertyClass();
                txtPretraga.Enabled = true;
                txtPretraga.Text = "";
                lblPretraga.Text = "Pretraga po nazivu filma";
                state = StateEnum.Preview;
                PonistiBoje();
                btnFilm.FlatAppearance.BorderColor = Color.Orange;
                btnFilm.FlatAppearance.BorderSize = 1;
                
            }

            else if (btnLogin == sender as Button || pbLogin == sender as PictureBox)
            {
                property = new LoginPropertyClass();
                txtPretraga.Text = "";
                txtPretraga.Enabled = true;
                lblPretraga.Text = "Pretraga po imenu/prezimenu zaposlenog";
                state = StateEnum.Preview;
                PonistiBoje();
                btnLogin.FlatAppearance.BorderColor = Color.Orange;
                btnLogin.FlatAppearance.BorderSize = 1;
            }
            else if (btnTermini == sender as Button || pbTermini == sender as PictureBox)
            {
                property = new TerminPropertyClass();
                txtPretraga.Text = "";
                txtPretraga.Enabled = true;
                lblPretraga.Text = "Pretraga po vremenu prikazivanja u formatu(00:00:00)";
                state = StateEnum.Preview;
                PonistiBoje();
                btnTermini.FlatAppearance.BorderColor = Color.Orange;
                btnTermini.FlatAppearance.BorderSize = 1;
            }
            else if (btnProjekcija == sender as Button || pbProjekcija == sender as PictureBox)
            {
                property = new ProjekcijaPropertyClass();
                txtPretraga.Text = "";
                txtPretraga.Enabled = true;
                lblPretraga.Text = "Pretraga po filmu";
                state = StateEnum.Preview;
                PonistiBoje();
                btnProjekcija.FlatAppearance.BorderColor = Color.Orange;
                btnProjekcija.FlatAppearance.BorderSize = 1;
            }
            else if (btnZanr == sender as Button || pbZanr == sender as PictureBox)
            {
                property = new ZanrPropertyClass();
                txtPretraga.Text = "";
                txtPretraga.Enabled = true;
                lblPretraga.Text = "Pretraga po zanru";
                state = StateEnum.Preview;
                PonistiBoje();
                btnZanr.FlatAppearance.BorderColor = Color.Orange;
                btnZanr.FlatAppearance.BorderSize = 1;
            }

            else if (btnZaposleni == sender as Button || pbZaposleni == sender as PictureBox)
            {
                property = new ZaposleniPropertyClass();
                txtPretraga.Text = "";
                txtPretraga.Enabled = true;
                lblPretraga.Text = "Pretraga po imenu/prezimenu zaposlenog";
                state = StateEnum.Preview;
                PonistiBoje();
                btnZaposleni.FlatAppearance.BorderColor = Color.Orange;
                btnZaposleni.FlatAppearance.BorderSize = 1;
            }
            UcitajDGV(property);

        }

        //Zavisno od tog u kom smo meniju pravi kontrole u panelu (PRAZNE) 
        private void postaviControle(PropertyInterface property)
        {
            ocistiKontrole();
            var properties = property.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                {
                    PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                                CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className)
                                as PropertyInterface;
                    UserLookUpControl ul = new UserLookUpControl(foreignKeyInterface);
                    ul.Name = item.Name;
                    ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                    ul.Zabrani();
                    flpDetaljno.Controls.Add(ul);
                }
                else if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                {
                    RichTextBoxControl rc = new RichTextBoxControl();
                    rc.Name = item.Name;
                    rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(rc);
                }
                else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl dc = new DateTimeControl();
                    dc.Name = item.Name;
                    dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    dc.SetVrijednost(DateTime.Now.ToShortDateString());
                    flpDetaljno.Controls.Add(dc);

                }
                else if (item.GetCustomAttribute<CheckBoxAttribute>() != null)
                {
                    CheckBoxControl cb = new CheckBoxControl();
                    cb.Name = item.Name;
                    cb.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(cb);
                }
                else if (item.GetCustomAttribute<NumericAttribute>() != null)
                {
                    NumericUpDownControl num = new NumericUpDownControl();
                    num.Name = item.Name;
                    num.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(num);
                }
                else //if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    if ((item.GetCustomAttribute<PrimaryKeyAttribute>() != null)||
                        (property.GetType() == typeof(ProjekcijaPropertyClass) && item.GetCustomAttribute<DisplayNameAttribute>().DisplayName == "Naziv filma"))
                    {
                        continue;
                    }
                    if (item.GetCustomAttribute<TimeAttribute>() != null)
                        uc.SetTextBox("00:00:00");
                    uc.Name = item.Name;
                    
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }

            }
        }

        //popunjava property podatcima iz selektovanog reda u  DataGridView
        private void PopulatePropertyInterface(PropertyInterface property)
        {
            try
            {
                DataGridViewRow row = dgvPrikaz.SelectedRows[0];
                var properties = property.GetType().GetProperties();
                foreach (PropertyInfo item in properties)
                {
                    string value = row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Naziv]
                       .Value.ToString();
                    if (item.GetCustomAttribute<TimeAttribute>() != null)
                    {
                        TimeSpan time = TimeSpan.Parse(value);
                        item.SetValue(property, Convert.ChangeType(time, item.PropertyType));
                    }
                    else
                        item.SetValue(property, Convert.ChangeType(value, item.PropertyType));
                }
            }
            catch { }
        }

        //Pravi i popunjava detaljan prokaz podataka iz selektovanog reda
        private void popuniDetaljno(PropertyInterface property, StateEnum state)
        {
            try
            {
                if (dgvPrikaz.SelectedRows.Count > 0)
                {
                    ocistiKontrole();
                    foreach (PropertyInfo item in property.GetType().GetProperties())
                    {
                        if (item.GetCustomAttribute<ForeignKeyAttribute>() != null)
                        {
                            PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                                CreateInstance(item.GetCustomAttribute<ForeignKeyAttribute>().className)
                                as PropertyInterface;
                            UserLookUpControl ul = new UserLookUpControl(foreignKeyInterface);
                            ul.Name = item.Name;
                            ul.Zabrani();
                            ul.SetLabel(item.GetCustomAttribute<DisplayNameAttribute>().DisplayName);
                            ul.SetKey(item.GetValue(property).ToString());

                            DataTable dt = new DataTable();
                            string query = @"select * from " + item.GetCustomAttribute<ForeignKeyAttribute>().referencedTable +
                                            " where " + item.GetCustomAttribute<SqlNameAttribute>().Naziv + "=" + ul.getKey();
                            //MessageBox.Show(query);
                            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, query);

                            dt.Load(reader);
                            reader.Close();

                            string colName = dt.Columns[1].ColumnName;
                            string colValue = "";
                            if (colName == "Ime")
                                colValue = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                            else if (colName.Contains("ID"))
                            {
                                PropertyInterface foreignKeyInterface1 = new FilmPropertyClass();
                                DataTable dt1 = new DataTable();
                                SqlDataReader reader1 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                                    foreignKeyInterface1.GetLookUpQuery(dt.Rows[0][1].ToString()));

                                dt1.Load(reader1);
                                reader1.Close();
                                colValue = dt1.Rows[0][0].ToString();

                            }
                            else try
                                {
                                    colValue = dt.Rows[0][1].ToString();
                                }
                                catch
                                {
                                }

                            ul.SetValue(colValue);
                            flpDetaljno.Controls.Add(ul);
                            if (state == StateEnum.Preview)
                                ul.Zakljucaj();//Zakljucaj nakon sto se spojimo sa markom 
                        }
                        else if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                        {
                            RichTextBoxControl rc = new RichTextBoxControl();
                            rc.Name = item.Name;
                            rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            rc.SetVrijednost(item.GetValue(property).ToString());
                            flpDetaljno.Controls.Add(rc);
                            if (state == StateEnum.Preview)
                                rc.Zabrani();

                        }
                        else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                        {
                            DateTimeControl dc = new DateTimeControl();
                            dc.SetVrijednost(item.GetValue(property).ToString());
                            dc.Name = item.Name;
                            dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            flpDetaljno.Controls.Add(dc);
                            if (state == StateEnum.Preview)
                                dc.Zabrani();
                        }
                        else if (item.GetCustomAttribute<CheckBoxAttribute>() != null)
                        {
                            CheckBoxControl cb = new CheckBoxControl();
                            cb.SetValue(Convert.ToBoolean(item.GetValue(property)));
                            cb.Name = item.Name;
                            cb.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            flpDetaljno.Controls.Add(cb);
                            if (state == StateEnum.Preview)
                                cb.Zabrani();
                        }
                        else if (item.GetCustomAttribute<NumericAttribute>() != null)
                        {
                            NumericUpDownControl num = new NumericUpDownControl();
                            num.SetValue(Convert.ToDecimal(item.GetValue(property)));
                            num.Name = item.Name;
                            num.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            flpDetaljno.Controls.Add(num);
                            if (state == StateEnum.Preview)
                                num.Zabrani();
                        }
                        else
                        {
                            if (item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Lozinka")
                                continue;
                            else if (item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Naziv filma"
                                        && property.GetType() == typeof(ProjekcijaPropertyClass))
                                continue;
                            else
                            {
                                TextBoxControl uc = new TextBoxControl();
                                uc.Name = item.Name;
                                uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                                uc.SetTextBox(item.GetValue(property).ToString());

                                if (item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                                {
                                    uc.Zabrani();
                                }
                                flpDetaljno.Controls.Add(uc);
                                if (state == StateEnum.Preview)
                                    uc.Zabrani();
                            }
                        }

                    }
                    if (property.GetType() == typeof(LoginPropertyClass))
                        dgvPrikaz.Columns["Lozinka"].Visible = false;

                    if (state == StateEnum.Preview)
                    {
                        panelDugmici.Visible = false;
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                MessageBox.Show(e.Message);
            }
        }
        public void ocistiKontrole()
        {
            flpDetaljno.Controls.Clear();
        }
        private void UcitajDGV(PropertyInterface property)
        {
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, property.GetSelectQuery());
            dt.Load(reader);
            reader.Close();
            dgvPrikaz.DataSource = null;
            dgvPrikaz.DataSource = dt;
            var prop = property.GetType().GetProperties();

            foreach (DataGridViewColumn item in dgvPrikaz.Columns)
            {
                item.HeaderText = prop.Where(x => x.GetCustomAttributes<SqlNameAttribute>().FirstOrDefault().Naziv ==
                item.HeaderText).FirstOrDefault().GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName;
            }


        }


        private void dgvPrikaz_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrikaz.SelectedRows.Count == 1)
            {
                PopulatePropertyInterface(property);
                popuniDetaljno(property, state);
            }
        }
        //klik na toolstrip ikonicu koja omogucava izmjenu nad trenutno selektovanim redom u data grid view-u
        private void tsbtnIzmijeni_Click(object sender, EventArgs e)
        {
            tsbtnIzmijeni.FlatAppearance.BorderColor = Color.Orange;
            tsbtnIzmijeni.FlatAppearance.BorderSize = 1;
            tsbtnAdd.FlatAppearance.BorderSize = 0;
            gbDetaljno.Select();
            state = StateEnum.Update;
            PopulatePropertyInterface(property);
            popuniDetaljno(property, state);
            txtPretraga.Enabled = false;
            panelDugmici.Visible = true;
            btnPotvrdi.Text = "Izmjeni";
            txtPretraga.Text = "";
        }

        //klik na toolstrip ikonicu koja omogucava dodavanje novog reda  u trenutno odabranu tabelu
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            tsbtnAdd.FlatAppearance.BorderColor = Color.Orange;
            tsbtnAdd.FlatAppearance.BorderSize = 1;
            tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
            gbDetaljno.Select();
            postaviControle(property);
            state = StateEnum.Create;
            txtPretraga.Enabled = false;
            panelDugmici.Visible = true;
            btnPotvrdi.Text = "Dodaj";
            txtPretraga.Text = "";
        }
        // unos promjena u bazu, bilo izmjena na nekom od redu ili dodavanje novog u tabelu
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            tsbtnAdd.FlatAppearance.BorderSize = 0;
            tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
            var properties = property.GetType().GetProperties();

            foreach (var item in flpDetaljno.Controls)
            {
                if (item.GetType() == typeof(TextBoxControl))
                {
                    TextBoxControl input = item as TextBoxControl;

                    if (input.Name == "DuzinaTrajanja" || input.Name == "VrijemePrikazivanja")
                    {

                        TimeSpan pom = new TimeSpan(0, 0, 0);
                        if (TimeSpan.TryParse(input.GetTextBox(), out pom))
                        {
                            TimeSpan valueT = TimeSpan.ParseExact(input.GetTextBox(), "c", null);
                            PropertyInfo myPropertyT = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                            myPropertyT.SetValue(property, Convert.ChangeType(valueT, myPropertyT.PropertyType));
                        }
                        else
                        {
                            MessageBox.Show("Vrijeme nije u ispravnom formatu!" + input.GetTextBox());
                            input.BackColor = Color.Red;
                            return;
                        }
                        if (input.Name == "Lozinka" && input.GetTextBox().Length <= 6)
                        {
                            MessageBox.Show("Lozinka mora biti bar 6  karatktera duga!");
                            return;
                        }
                    }


                    else
                    {
                        PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        string value = input.GetTextBox();
                        if (value.Trim() == "" && myProperty.GetCustomAttribute<MandatoryDataAttribute>() != null)
                        {
                            MessageBox.Show("Polje " + input.Name + " je obavezno, popunite ga! ");
                            input.BackColor = Color.Red;
                            return;
                        }
                        if (input.Name == "Pol" && (value == "M" || value == "Ž"))
                            continue;
                        else if (input.Name == "Pol" && (value != "M" || value != "Ž"))
                        {
                            MessageBox.Show("Polje pol mora biti jedan karakter (M ili Ž)");
                            return;
                        }

                        else
                        {
                            myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                            input.BackColor = Color.FromArgb(38, 38, 38);
                        }

                    }

                }

                //Marko J. Pokusaji rjesavanja dopune svih polja prilikom unosa i updatea
                else if (item.GetType() == typeof(RichTextBoxControl))
                {
                    RichTextBoxControl input = item as RichTextBoxControl;
                    string value = input.GetVrijednost();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    if (myProperty.GetCustomAttribute<MandatoryDataAttribute>() != null && input.GetVrijednost().Trim() == "")
                    {
                        MessageBox.Show("Polje " + input.Name + " je obavezno, popunite ga! ");
                        input.BackColor = Color.Red;
                        return;
                    }
                    else
                        myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                    input.BackColor = Color.FromArgb(38, 38, 38);
                }
                else if (item.GetType() == typeof(DateTimeControl))
                {
                    DateTimeControl input = item as DateTimeControl;
                    string value = input.GetVrijednost();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    if (myProperty.GetCustomAttribute<MandatoryDataAttribute>() != null && input.GetVrijednost().Trim() == "")
                    {
                        MessageBox.Show("Polje " + input.Name + " je obavezno, popunite ga! ");
                        input.BackColor = Color.Red;
                        return;
                    }
                    else
                        myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                    input.BackColor = Color.FromArgb(38, 38, 38);
                }
                else if (item.GetType() == typeof(NumericUpDownControl))
                {
                    NumericUpDownControl input = item as NumericUpDownControl;
                    string value = input.GetValue().ToString().Trim();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    if (myProperty.GetCustomAttribute<MandatoryDataAttribute>() != null && input.GetValue().ToString().Trim() == "")
                    {
                        MessageBox.Show("Polje " + input.Name + " je obavezno, popunite ga! ");
                        input.BackColor = Color.Red;
                        return;
                    }
                    else
                        myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                    input.BackColor = Color.FromArgb(38, 38, 38);
                }
                else if (item.GetType() == typeof(UserLookUpControl))
                {
                    UserLookUpControl input = item as UserLookUpControl;
                    string value = input.getKey().ToString();
                    int provjera = 0;
                    if (value.Trim() == "" || int.TryParse(value, out provjera) == false)
                    {
                        MessageBox.Show("Polje " + input.Name + " je obavezno, popunite ga! ");
                        input.BackColor = Color.Red;
                        return;
                    }
                    else
                    {
                        PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                        input.BackColor = Color.FromArgb(38, 38, 38);
                    }
                }
                else if (item.GetType() == typeof(CheckBoxControl))
                {
                    CheckBoxControl input = item as CheckBoxControl;
                    bool value = input.GetValue();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                }
            }

            if (state == StateEnum.Create)
            {
                if (DialogResult.Yes == (MessageBox.Show("Da li ste sigurni da zelite da dodate novi red?", "Poruka!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
                {
                    SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, property.GetInsertQuery(), property.GetInsertParameters().ToArray());
                }
                else state = StateEnum.Preview;
            }
            else if (state == StateEnum.Update)
            {
                if (DialogResult.Yes == (MessageBox.Show("Da li ste sigurni da zelite da izmjenite odabrani red?", "Poruka!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
                {
                    SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, property.GetUpdateQuery(), property.GetUpdateParameters().ToArray());
                }
                else state = StateEnum.Preview;
            }

            UcitajDGV(property);
            state = StateEnum.Preview;
            txtPretraga.Enabled = true;

            panelDugmici.Visible = false;

        }

        private void tsbtnObrisi_Click(object sender, EventArgs e)
        {
            tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
            tsbtnAdd.FlatAppearance.BorderSize = 0;
            panelDugmici.Visible = false;
            try
            {
                var properties = property.GetType().GetProperties();

                PropertyInfo myProperty = properties.Where(x => x.IsDefined(typeof(PrimaryKeyAttribute))).FirstOrDefault();
                myProperty.SetValue(property, Convert.ChangeType(dgvPrikaz.SelectedRows[0].Cells[0].Value, myProperty.PropertyType));
                if (DialogResult.Yes == (MessageBox.Show("Da li zelite da izbrisete izabrani red?", "Informacija o brisanju", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning)))
                {
                    SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, property.GetDeleteQuery(), property.GetDeleteParameters().ToArray());
                    UcitajDGV(property);
                }
                state = StateEnum.Preview;
                txtPretraga.Enabled = true;
            }
            catch
            {
                if (property.GetType() == typeof(FilmPropertyClass))
                {
                    MessageBox.Show("Film je koristen u jednom od repertoara i ne moze biti obrisan!", "Poruka", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            tsbtnAdd.FlatAppearance.BorderSize = 0;
            tsbtnIzmijeni.FlatAppearance.BorderSize = 0; 
            panelDugmici.Visible = false;
            state = StateEnum.Preview;
            txtPretraga.Enabled = true;
            SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, property.GetUpdateQuery(), property.GetUpdateParameters().ToArray());
            UcitajDGV(property);
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, property.GetSearchQuery(txtPretraga.Text));

            dt.Load(reader);
            reader.Close();
            dgvPrikaz.DataSource = dt;
        }

       

        #region promjena_boje_na_hover

        private void btnZaposleni_MouseEnter(object sender, EventArgs e)
        {

            btnZaposleni.BackColor = Color.FromArgb(255, 128, 0);
            pbZaposleni.BackColor = Color.FromArgb(255, 128, 0);

        }

        private void btnZaposleni_MouseLeave(object sender, EventArgs e)
        {
            btnZaposleni.BackColor = Color.FromArgb(52, 52, 52);
            pbZaposleni.BackColor = Color.Transparent;
        }

        private void btnFilm_MouseEnter(object sender, EventArgs e)
        {
            btnFilm.BackColor = Color.FromArgb(255, 128, 0);
            pbFilm.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnFilm_MouseLeave(object sender, EventArgs e)
        {
            btnFilm.BackColor = Color.FromArgb(52, 52, 52);
            pbFilm.BackColor = Color.Transparent;
        }

        private void btnTermini_MouseEnter(object sender, EventArgs e)
        {
            btnTermini.BackColor = Color.FromArgb(255, 128, 0);
            pbTermini.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnTermini_MouseLeave(object sender, EventArgs e)
        {
            btnTermini.BackColor = Color.FromArgb(52, 52, 52);
            pbTermini.BackColor = Color.Transparent;
        }

        private void btnProjekcija_MouseEnter(object sender, EventArgs e)
        {
            btnProjekcija.BackColor = Color.FromArgb(255, 128, 0);
            pbProjekcija.BackColor = Color.FromArgb(255, 128, 0);

        }

        private void btnProjekcija_MouseLeave(object sender, EventArgs e)
        {
            btnProjekcija.BackColor = Color.FromArgb(52, 52, 52);
            pbProjekcija.BackColor = Color.Transparent;
        }

        private void btnZanr_MouseEnter(object sender, EventArgs e)
        {
            btnZanr.BackColor = Color.FromArgb(255, 128, 0);
            pbZanr.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnZanr_MouseLeave(object sender, EventArgs e)
        {
            btnZanr.BackColor = Color.FromArgb(52, 52, 52);
            pbZanr.BackColor = Color.Transparent;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            pbLogin.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(52, 52, 52);
            pbLogin.BackColor = Color.Transparent;
        }
        private void btnIzvjestaji_MouseEnter(object sender, EventArgs e)
        {
            btnIzvjestaji.BackColor = Color.FromArgb(255, 128, 0);
            pbIzvjestaji.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnIzvjestaji_MouseLeave(object sender, EventArgs e)
        {
            btnIzvjestaji.BackColor = Color.FromArgb(52, 52, 52);
            pbIzvjestaji.BackColor = Color.Transparent;
        }

        #endregion

        private void dgvPrikaz_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvPrikaz.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dgvPrikaz.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 128);
                }
            }

        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            Izvjestaji forma = new Izvjestaji();
            forma.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            try
            {
                label1.Text = DateTime.Now.ToString("ss");
                lblSatKrug.Text = DateTime.Now.ToString("HH:mm");
                //label2.Text = DateTime.Now.ToString("hh:mm");
                //label3.Text = DateTime.Now.ToString("dddd");
                lblDatum.Text = DateTime.Now.ToString("dd/M/yyyy");
                circularProgressBar1.Value = Convert.ToInt32(label1.Text);

            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
