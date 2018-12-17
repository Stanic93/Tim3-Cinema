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
    public partial class UserLookUpControl : UserControl
    {
        PropertyInterface myInterface;
        public string Key;
        public string Value;
        public UserLookUpControl(PropertyInterface property)
        {
            InitializeComponent();
            myInterface = property;
        }

        public void SetLabel(string text)
        {
            lblNaziv.Text = text;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LookUpForm novaForma = new LookUpForm(myInterface);
            novaForma.ShowDialog();
            Key = novaForma.Key;
            Value = novaForma.Value;
            txtValue.Text = Value;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
