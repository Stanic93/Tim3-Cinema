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
            OsnovnaPodesavanja();



            #region PocetnoUcitavanjaDataGrid
            UcitajDGV(property);
            #endregion
        }
        public void iskljuciPaneleNaDugmadima()
        {
            panelZaposleniSelected.Visible = false;
            panelFilmSelected.Visible = false;
            panelProjekcijaSelected.Visible = false;
            panelZanrSelected.Visible = false;
            panelLoginSelected.Visible = false;
            panelTerminiSelected.Visible = false;
        }

        public void OsnovnaPodesavanja()
        {
            dgvPrikaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrikaz.MultiSelect = false;
            dgvPrikaz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrikaz.EditMode = DataGridViewEditMode.EditProgrammatically;
            postaviControle(property);


        }
        //ucitava dataGridView tabelom zavisno od tog na koji od menija je kliknuto
        private void Btn_Click(object sender, EventArgs e)
        {
            if (btnFilm == sender as Button)
            {
                property = new FilmPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelFilmSelected.Visible = true;
                lblPretraga.Text = "Pretraga po nazivu filma";
                state = StateEnum.Preview;
            }

            else if (btnLogin == sender as Button)
            {
                property = new LoginPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelLoginSelected.Visible = true;
                lblPretraga.Text = "Pretraga po imenu/prezimenu zaposlenog";
                state = StateEnum.Preview;
            }
            else if (btnTermini == sender as Button)
            {
                property = new TerminPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelTerminiSelected.Visible = true;
                lblPretraga.Text = "Pretraga po vremenu prikazivanja";
                state = StateEnum.Preview;
            }
            else if (btnProjekcija == sender as Button)
            {
                property = new ProjekcijaPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelProjekcijaSelected.Visible = true;
                lblPretraga.Text = "Pretraga po filmu";
                state = StateEnum.Preview;
            }
            else if (btnZanr == sender as Button)
            {
                property = new ZanrPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelZanrSelected.Visible = true;
                lblPretraga.Text = "Pretraga po nazivu zanra";
                state = StateEnum.Preview;
            }

            else if (btnZaposleni == sender as Button)
            {
                property = new ZaposleniPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelZaposleniSelected.Visible = true;
                lblPretraga.Text = "Pretraga po imenu/prezimenu zaposlenog";
                state = StateEnum.Preview;
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
                    dc.SetVrijednost("01.01.2018");
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
                    if (item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                    {
                        continue;
                    }
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }

            }
            flpDetaljno.Enabled = true;
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
                                // MessageBox.Show("tap");
                                SqlDataReader reader1 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                                    foreignKeyInterface1.GetLookUpQuery(dt.Rows[0][1].ToString()));

                                dt1.Load(reader1);
                                reader1.Close();
                                colValue = dt1.Rows[0][0].ToString();

                            }
                            else
                                colValue = dt.Rows[0][1].ToString();
                            //MessageBox.Show(colName + "je colName, col1 vrijednost je=" + colValue);

                            ul.SetValue(colValue);
                            flpDetaljno.Controls.Add(ul);
                        }
                        else if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                        {
                            RichTextBoxControl rc = new RichTextBoxControl();
                            rc.Name = item.Name;
                            rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            rc.SetVrijednost(item.GetValue(property).ToString());
                            flpDetaljno.Controls.Add(rc);

                        }
                        else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                        {
                            DateTimeControl dc = new DateTimeControl();


                            dc.SetVrijednost(item.GetValue(property).ToString());
                            dc.Name = item.Name;
                            dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            //dc.SetVrijednost("01.01.2018");
                            flpDetaljno.Controls.Add(dc);

                        }
                        else if (item.GetCustomAttribute<CheckBoxAttribute>() != null)
                        {
                            CheckBoxControl cb = new CheckBoxControl();
                            cb.SetValue(Convert.ToBoolean(item.GetValue(property)));
                            cb.Name = item.Name;
                            cb.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            flpDetaljno.Controls.Add(cb);
                        }
                        else if (item.GetCustomAttribute<NumericAttribute>() != null)
                        {
                            NumericUpDownControl num = new NumericUpDownControl();
                            num.SetValue(Convert.ToDecimal(item.GetValue(property)));
                            num.Name = item.Name;
                            num.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            flpDetaljno.Controls.Add(num);
                        }
                        else //if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                        {
                            if (item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Lozinka")
                                continue;
                            else
                            {
                                TextBoxControl uc = new TextBoxControl();
                                uc.Name = item.Name;
                                uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                                uc.SetTextBox(item.GetValue(property).ToString());

                                if (item.GetCustomAttribute<PrimaryKeyAttribute>() != null)
                                {
                                    uc.Enabled = false;
                                }
                                flpDetaljno.Controls.Add(uc);
                            }
                        }

                    }
                    if (property.GetType() == typeof(LoginPropertyClass))
                        dgvPrikaz.Columns["Lozinka"].Visible = false;

                    if (state == StateEnum.Preview)
                    {
                        flpDetaljno.Enabled = false;
                        panelDugmici.Visible = false;
                    }
                    else
                        flpDetaljno.Enabled = true;
                }
            }
            catch (Exception e)
            {
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
        //private void dgvPrikaz_Click(object sender, EventArgs e)
        //{
        //    postaviControle(property);
        //}

        private void dgvPrikaz_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrikaz.SelectedRows.Count == 1)
            {
                PopulatePropertyInterface(property);
                popuniDetaljno(property, state);
            }
        }

        private void tsbtnIzmjein_Click(object sender, EventArgs e)
        {
            state = StateEnum.Update;
            PopulatePropertyInterface(property);
            popuniDetaljno(property, state);
            panelDugmici.Visible = true;
            btnPotvrdi.Text = "Izmjeni";
        }


        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            postaviControle(property);
            state = StateEnum.Create;
            panelDugmici.Visible = true;
            btnPotvrdi.Text = "Dodaj";
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            var properties = property.GetType().GetProperties();

            foreach (var item in flpDetaljno.Controls)
            {
                if (item.GetType() == typeof(TextBoxControl))
                {
                    TextBoxControl input = item as TextBoxControl;
                   
                    if (input.Name == "DuzinaTrajanja" || input.Name == "VrijemePrikazivanja")
                    {
                        TimeSpan valueT = TimeSpan.ParseExact(input.GetTextBox(), "c", null);
                        PropertyInfo myPropertyT = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        myPropertyT.SetValue(property, Convert.ChangeType(valueT, myPropertyT.PropertyType));
                    }
                    else
                    {
                        string value = input.GetTextBox();
                        PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                        myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                    }
                }

                //Marko J. Pokusaji rjesavanja dopune svih polja prilikom unosa i updatea
                else if (item.GetType() == typeof(RichTextBoxControl))
                {
                    RichTextBoxControl input = item as RichTextBoxControl;
                    string value = input.GetVrijednost();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                }
                else if (item.GetType() == typeof(DateTimeControl))
                {
                    DateTimeControl input = item as DateTimeControl;
                    string value = input.GetVrijednost();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                }
                else if (item.GetType() == typeof(NumericUpDownControl))
                {
                    NumericUpDownControl input = item as NumericUpDownControl;
                    string value = input.GetValue().ToString();
                    MessageBox.Show(value);
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
                }
                else if (item.GetType() == typeof(UserLookUpControl))
                {
                    UserLookUpControl input = item as UserLookUpControl;
                    string value = input.getKey().ToString();
                    PropertyInfo myProperty = properties.Where(x => input.Name == x.Name).FirstOrDefault();
                    myProperty.SetValue(property, Convert.ChangeType(value, myProperty.PropertyType));
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
                        MessageBox.Show("Dodavanje uspjesno izvrseno!");

                    }
                }
                else if (state == StateEnum.Update)
                {
                    if (DialogResult.Yes == (MessageBox.Show("Da li ste sigurni da zelite da izmjenite odabrani red?", "Poruka!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
                    {
                        SqlHelper.ExecuteNonQuery(SqlHelper.GetConnectionString(), CommandType.Text, property.GetUpdateQuery(), property.GetUpdateParameters().ToArray());
                        MessageBox.Show("Izmjena uspjesno izvrsena!");
                    }
                }

                UcitajDGV(property);
                state = StateEnum.Preview;
                flpDetaljno.Enabled = false;
                panelDugmici.Visible = false;
            
        }

        private void tsbtnObrisi_Click(object sender, EventArgs e)
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
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            flpDetaljno.Enabled = false;
            panelDugmici.Visible = false;
            state = StateEnum.Preview;
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
    }
}
