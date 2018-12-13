using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           // this.Location = Screen.AllScreens[1].WorkingArea.Location; // form load on current working monitor
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
            if (userU == false || textBox1.Text == "Korisnicko ime")
            {
                userU = true;
                textBox1.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (passU == false || textBox2.Text == "Lozinka")
            {
                passU = true;
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                textBox1.Text = "Korisnicko ime";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == " ")
            {
                textBox2.Text = "Lozinka";
            }
        }
    }
}
