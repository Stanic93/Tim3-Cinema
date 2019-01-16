using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.PropertyClass;

namespace Cinema.Controle
{
    public partial class UserLookUpControl : UserControl
    {
        PropertyInterface myInterface;
        public string Key;
        public string Value;
        public int terminID;
        public UserLookUpControl(PropertyInterface property)
        {
            InitializeComponent();
            myInterface = property;
        }
        public UserLookUpControl(PropertyInterface property,int terminID)
        {
            InitializeComponent();
            myInterface = property;
            this.terminID = terminID;
        }

        public void SetLabel(string text)
        {
            lblNaziv.Text = text;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (myInterface.GetType() == typeof(SjedistePropertyClass))
            {
                LookUpForm novaForma1 = new LookUpForm(myInterface, terminID);
                novaForma1.ShowDialog();
                Key = novaForma1.Key;
                Value = novaForma1.Value;
                txtValue.Text = Value;
                txtKeyValue.Text = Key;
                return;
            }
            else
            {
                LookUpForm novaForma = new LookUpForm(myInterface);
                novaForma.ShowDialog();
                Key = novaForma.Key;
                Value = novaForma.Value;
                txtValue.Text = Value;
                txtKeyValue.Text = Key;
            }
        }
        public void SetValue(string value)
        {
            txtValue.Text = value;
        }
        public void SetKey(string key)
        {
            txtKeyValue.Text = key;
        }
        public string getKey()
        {
            return txtKeyValue.Text;
        }
        public void Zabrani()
        {
            txtKeyValue.ReadOnly=true;
            txtValue.ReadOnly = true;
        }
    }
}
