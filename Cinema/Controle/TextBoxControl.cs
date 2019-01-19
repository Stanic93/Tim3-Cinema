using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Controle
{
    public partial class TextBoxControl : UserControl
    {
        public TextBoxControl()
        {
            InitializeComponent();
            lblNaziv.ForeColor = SystemColors.Control;
        }
        public void SetLabel(string value)
        {
            lblNaziv.Text = value;
        }
        public void SetTextBox(string value)
        {
            txtVrijednost.Text = value;
        }
        public string GetTextBox()
        {
            return txtVrijednost.Text;
        }
        public void Zabrani()
        {
            txtVrijednost.ReadOnly = true;
        }
    }
}
