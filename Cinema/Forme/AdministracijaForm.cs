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

        PropertyInterface property = new ZaposleniPropertyClass();
        ActiveTab activeTab;
        public AdministracijaForm()
        {
            InitializeComponent();
            btnZaposleni.Click += Btn_Click;
            btnZanr.Click += Btn_Click;
            btnProjekcija.Click += Btn_Click;
            btnLogin.Click += Btn_Click;
            btnFilm.Click += Btn_Click;

            OsnovnaPodesavanja();

            #region PocetnoUcitavanja
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
        }

        public void OsnovnaPodesavanja()
        {
            dgvPrikaz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            PropertyInterface property = new FilmPropertyClass();
            if (btnFilm == sender as Button)
            {
                property = new FilmPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelFilmSelected.Visible = true;
                activeTab = ActiveTab.Film;
            }

            else if (btnLogin == sender as Button)
            {
                property = new LoginPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelLoginSelected.Visible = true;
                activeTab = ActiveTab.Login;
            }
            else if (btnTermini == sender as Button)
            {
                //property = new TerminPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelTerminiSelected.Visible = true;
                activeTab = ActiveTab.Termini;
            }
            else if (btnProjekcija == sender as Button)
            {
                property = new ProjekcijaPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelProjekcijaSelected.Visible = true;
                activeTab = ActiveTab.Projekcija;
            }
            else if (btnZanr == sender as Button)
            {
                property = new ZanrPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelZanrSelected.Visible = true;
                activeTab = ActiveTab.Zanr;
            }

            else if (btnZaposleni == sender as Button)
            {
                property = new ZaposleniPropertyClass();
                iskljuciPaneleNaDugmadima();
                panelZaposleniSelected.Visible = true;
                activeTab = ActiveTab.Zaposleni;
            }
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

        private void popuniControle(PropertyInterface property)
        {
            var properties = property.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                //if (activeTab == ActiveTab.Karta)
                //{
                //    if (item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Aktivan" 
                //        || item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Film ID" 
                //        || item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Godina")
                //    {
                //        continue;
                //    }
                //}
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

                else if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    uc.ReadOnly();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }
            }
        }

        private void dgvPrikaz_Click(object sender, EventArgs e)
        {
            popuniControle(new ZaposleniPropertyClass());
        }

        
    }
}
