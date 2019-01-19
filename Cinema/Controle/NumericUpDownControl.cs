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
    public partial class NumericUpDownControl : UserControl
    {
        public NumericUpDownControl()
        {
            InitializeComponent();
            lblNaziv.ForeColor = Color.White;
            lblNaziv.BackColor = Color.Transparent;
        }
        public void SetLabel(string value)
        {
            lblNaziv.Text = value;
        }
        public void SetValue(int value)
        {
            numUpDown.Value = value;
        }public void SetValue(decimal value)
        {
            numUpDown.Value =  value;
        }
        public int GetValue()
        {
            return Convert.ToInt16( numUpDown.Value);
        }
        public void Zabrani()
        {
            numUpDown.ReadOnly = true;
        }
    }
}
