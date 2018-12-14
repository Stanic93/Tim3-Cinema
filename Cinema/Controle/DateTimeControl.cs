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
    public partial class DateTimeControl : UserControl
    {
        public DateTimeControl()
        {
            InitializeComponent();
        }
        public void SetLabel(string value)
        {
            lblNaziv.Text = value;
        }
        public void SetVrijednost(string value)
        {
            dtpVrijednost.Text = value;
        }
        public string GetVrijednost()
        {
            return dtpVrijednost.Text;
        }
        public void ReadOnly()
        {
            dtpVrijednost.Enabled = false;
        }
    }
}
