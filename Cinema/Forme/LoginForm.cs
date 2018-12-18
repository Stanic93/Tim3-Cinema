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

namespace Cinema.Forme
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        

        private void provjeriKorisnika(string Korisnicko, string Lozinka)
        {
           if (Korisnicko == "Korisnicko ime" || Korisnicko == "Korisnicko ime" && Lozinka == "Lozinka")
            {
                MessageBox.Show("Unesite korisnicko ime i lozinku", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = new DataTable();
            string connectionString = SqlHelper.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = @"Select * from dbo.Login where KorisnickoIme= @KorisnickoIme and Lozinka =@Lozinka";
            command.Connection = connection;
            SqlParameter parameter = new SqlParameter("@KorisnickoIme", SqlDbType.NVarChar);
            parameter.Value = Korisnicko;
            SqlParameter parameter2 = new SqlParameter("@Lozinka", SqlDbType.NVarChar);
            parameter2.Value = Lozinka;
            command.Parameters.Add(parameter);
            command.Parameters.Add(parameter2);
            SqlDataReader dataReader;
            try
            {
                connection.Open();
                dataReader = command.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch 
            {
                MessageBox.Show("Can not open connection");
            }


            if (dt.Rows.Count != 1)
            {
                //"Nepravilno korisnicko ime ili lozinka"
                MessageBox.Show("Nepravilno korisnicko ime ili lozinka", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string jobtitle = "";
            foreach (DataRow row in dt.Rows)
            {
                jobtitle = row["RadnoMjesto"].ToString();
            }
            if (jobtitle == "Blagajnik")
            {
                BlagajnaForm novaForma = new BlagajnaForm();
                novaForma.ShowDialog();
            }
            else
            {
                AdministracijaForm novaForma = new AdministracijaForm();
                novaForma.ShowDialog();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {

            //provjeriKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);
            AdministracijaForm novaForma = new AdministracijaForm();
            novaForma.ShowDialog();


        }
    }
}
