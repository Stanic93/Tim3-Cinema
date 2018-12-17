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

namespace Cinema.Forme
{
    public partial class AdministracijaForm : Form
    {
        public AdministracijaForm()
        {
            InitializeComponent();
            btnZaposleni.Click += Btn_Click;
            btnZanr.Click += Btn_Click;
            btnProjekcija.Click += Btn_Click;
            btnLogin.Click += Btn_Click;
            btnFilm.Click += Btn_Click;
        }

        

        private void Btn_Click(object sender, EventArgs e)
        {
            PropertyInterface property;
            if (btnFilm == sender as Button)
                property = new FilmPropertyClass();
            else if (btnLogin == sender as Button)
                property = new LoginPropertyClass();
            else if (btnProjekcija == sender as Button)
                property = new ProjekcijaPropertyClass();
            else if (btnZanr == sender as Button)
                property = new ZanrPropertyClass();
            else  property = new ZaposleniPropertyClass();


            DataTable dt = new DataTable();
            
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, property.GetSelectQuery());

            dt.Load(reader);
            reader.Close();

            dgvPrikaz.DataSource = dt;
            var prop = property.GetType().GetProperties();

            foreach (DataGridViewColumn item in dgvPrikaz.Columns)
            {
                item.HeaderText = prop.Where(x => x.GetCustomAttributes<SqlNameAttribute>().FirstOrDefault().Naziv == 
                item.HeaderText).FirstOrDefault().GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName;
            }

        }
    }
}
