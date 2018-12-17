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
    public partial class CinemaLogin : Form
    {
        int mov;
        int movX;
        int movY;
        bool userU = false;
        bool passU = false;


        public CinemaLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CinemaLogin_Load(object sender, EventArgs e)
        {
          //  this.Location = Screen.AllScreens[1].WorkingArea.Location; // form load on current working monitor
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (userU == false || txtKorisnicko.Text == "Korisnicko ime")
            {
                userU = true;
                txtKorisnicko.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (passU == false || txtLozinka.Text == "Lozinka")
            {
                passU = true;
                txtLozinka.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtKorisnicko.Text == "" || txtKorisnicko.Text == " ")
            {
                txtKorisnicko.Text = "Korisnicko ime";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtLozinka.Text == "" || txtLozinka.Text == " ")
            {
                txtLozinka.Text = "Lozinka";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BlagajnaForm novaForma = new BlagajnaForm();
            novaForma.ShowDialog();
            // provjeriKorisnika(txtKorisnicko.Text,txtLozinka.Text);    
        }

        private void provjeriKorisnika(string Korisnicko,string Lozinka)
        {
            if(Korisnicko == "Korisnicko ime" || Korisnicko == "Korisnicko ime" && Lozinka == "Lozinka")
            {
                MessageBox.Show("Unesite korisnicko ime i lozinku","Poruka",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection");
            }
            

            if(dt.Rows.Count != 1)
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
            if(jobtitle == "Blagajnik")
            {
                BlagajnaForm novaForma = new BlagajnaForm();
                novaForma.ShowDialog();
            }else
            {
                // otvori formu za administratora
                MessageBox.Show("Otvorice formu administrator");
            }
        }
    }
}
