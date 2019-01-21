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
        int zaposleniID = 1;
        string ImeIPrezime = "";
        public LoginForm()
        {
            InitializeComponent();
        }


        private void KeyUp_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                provjeriKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);
            }
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
            command.CommandText = @"Select * from dbo.Login
                                    join dbo.Zaposleni on Login.ZaposleniID = Zaposleni.ZaposleniID
                                    where KorisnickoIme= @KorisnickoIme COLLATE SQL_Latin1_General_CP1_CS_AS 
                                    and Lozinka =@Lozinka COLLATE SQL_Latin1_General_CP1_CS_AS 
                                    and KorisnickoIme= @KorisnickoIme 
                                    and Lozinka =@Lozinka";
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
                string id = row["ZaposleniID"].ToString();
                string ime = row["Ime"].ToString();
                string prezime = row["Prezime"].ToString();
                ImeIPrezime = ime + " " + prezime;
                zaposleniID = Convert.ToInt32(id);

            }
            if (jobtitle == "Blagajnik")
            {
                BlagajnaForm novaForma = new BlagajnaForm(zaposleniID, ImeIPrezime);
                novaForma.ShowDialog();
                txtKorisnickoIme.Text = "";
                txtLozinka.Text = "";
            }
            else if (jobtitle == "Admin")
            {
                AdministracijaForm novaForma = new AdministracijaForm(ImeIPrezime);
                novaForma.ShowDialog();
                txtKorisnickoIme.Text = "";
                txtLozinka.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {

           provjeriKorisnika(txtKorisnickoIme.Text, txtLozinka.Text);
            //AdministracijaForm novaForma = new AdministracijaForm();
            //novaForma.ShowDialog();
            //BlagajnaForm nov = new BlagajnaForm(zaposleniID, ImeIPrezime);
            //nov.Show();


        }
    }
}
