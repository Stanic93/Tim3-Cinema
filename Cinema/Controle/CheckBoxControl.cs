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
    public partial class CheckBoxControl : UserControl
    {
        public CheckBoxControl()
        {
            InitializeComponent();
            lblcbNaziv.ForeColor = Color.White;
            
        }
        public void SetLabel(string value)
        {
            lblcbNaziv.Text = value;
        }
        public void SetValue(bool value) {
            checkBoxZauzeto.Checked = value;
        }
        public bool GetValue() {
            return checkBoxZauzeto.Checked;
        }
        public void Zabrani()
        {
            checkBoxZauzeto.Enabled = false;
        }
    }
}
