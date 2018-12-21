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
        public AdministracijaForm()
        {
            InitializeComponent();
            btnZaposleni.Click += Btn_Click;
            btnZanr.Click += Btn_Click;
            btnProjekcija.Click += Btn_Click;
            btnLogin.Click += Btn_Click;
            btnFilm.Click += Btn_Click;
            OsnovnaPodesavanja();
           

            #region PocetnoUcitavanjaDataGrid
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
            #endregion
        }
        public void iskljuciPaneleNaDugmadima() {
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
            popuniControle(property);
        }
        //ucitava dataGridView tabelom zavisno od tog na koji od menija je kliknuto
        private void Btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPrikaz.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dgvPrikaz.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dgvPrikaz.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
            }

            if (btnFilm == sender as Button)
            {
                property = new FilmPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelFilmSelected.Visible = true;                
            }

            else if (btnLogin == sender as Button)
            {
                property = new LoginPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelLoginSelected.Visible = true;                
            }
            else if (btnTermini == sender as Button)
            {
                property = new TerminPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelTerminiSelected.Visible = true;                
            }
            else if (btnProjekcija == sender as Button)
            {
                property = new ProjekcijaPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelProjekcijaSelected.Visible = true;                
            }
            else if (btnZanr == sender as Button)
            {
                property = new ZanrPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelZanrSelected.Visible = true;               
            }

            else if (btnZaposleni == sender as Button)
            {
                property = new ZaposleniPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelZaposleniSelected.Visible = true;                
            }
            popuniControle(property);
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

        //Zavisno od tog u kom smo meniju pravi kontrole u panelu (PRAZNE) 
        private void popuniControle(PropertyInterface property)
        {
            ocistiKontrole();
            var properties = property.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                
                if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                {
                    RichTextBoxControl rc = new RichTextBoxControl();
                    rc.ReadOnly();
                    rc.Name = item.Name;
                    rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(rc);
                    
                }
                else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl dc = new DateTimeControl();
                    dc.ReadOnly();
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
                else //if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    uc.ReadOnly();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }
                
            }
        }

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

                    item.SetValue(property, Convert.ChangeType(value, item.PropertyType));
                }
            }
            catch{ }
        }

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
                            flpDetaljno.Controls.Add(ul);
                        }
                        else if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                        {
                            RichTextBoxControl rc = new RichTextBoxControl();
                            rc.Name = item.Name;
                            rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            if (state == StateEnum.Preview)
                                rc.Enabled = false;
                            rc.SetVrijednost(item.GetValue(property).ToString());
                            flpDetaljno.Controls.Add(rc);

                        }
                        else if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                        {
                            DateTimeControl dc = new DateTimeControl();

                            if (state == StateEnum.Preview)
                                dc.Enabled = false;

                            dc.SetVrijednost(item.GetValue(property).ToString());
                            dc.Name = item.Name;
                            dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            //dc.SetVrijednost("01.01.2018");
                            flpDetaljno.Controls.Add(dc);

                        }
                        else if (item.GetCustomAttribute<CheckBoxAttribute>() != null)
                        {
                            CheckBoxControl cb = new CheckBoxControl();

                            if (state == StateEnum.Preview)
                                cb.Enabled = false;

                            cb.SetValue(Convert.ToBoolean(item.GetValue(property)));
                            cb.Name = item.Name;
                            cb.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            flpDetaljno.Controls.Add(cb);
                        }
                        else //if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                        {
                            TextBoxControl uc = new TextBoxControl();
                            uc.Name = item.Name;
                            uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                            if (state == StateEnum.Preview)
                                uc.Enabled = false;

                            uc.SetTextBox(item.GetValue(property).ToString());

                            if (item.GetCustomAttribute<PrimaryKeyAttribute>() != null && state == StateEnum.Update)
                            {
                                uc.Enabled = false;
                            }
                            flpDetaljno.Controls.Add(uc);
                        }

                    }
                }
            }
            catch  {}
        }



        public void ocistiKontrole() {
            flpDetaljno.Controls.Clear();
        }

        private void dgvPrikaz_Click(object sender, EventArgs e)
        {
            popuniControle(property);
        }

        private void dgvPrikaz_SelectionChanged(object sender, EventArgs e)
        {
           
            PopulatePropertyInterface(property);
            popuniDetaljno(property,state);
        }
    }
}
