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
using System.Reflection;
using Cinema.AttributeClass;

namespace Cinema
{
    public partial class LookUpForm : Form
    {
        public string Key;
        public string Value;
        PropertyInterface myProperty;
        public LookUpForm(PropertyInterface property)
        {
            InitializeComponent();
            myProperty = property;
            GetSelectAll();
        }

        public void GetSelectAll()
        {
            dgvPregledLookUp.DataSource = null;
            DataTable dt = new DataTable();
            SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, myProperty.GetSelectQuery());
            dt.Load(reader);
            reader.Close();
           
            dgvPregledLookUp.DataSource = dt;
            //izvuci display name
            var type = myProperty.GetType();
            var properties = type.GetProperties();


            //promjeniti nazive kolona
            foreach (DataGridViewColumn item in dgvPregledLookUp.Columns)
            {
                item.HeaderText = properties.Where(x => x.GetCustomAttributes<SqlNameAttribute>().FirstOrDefault().Naziv == item.HeaderText
                                      ).FirstOrDefault().GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName;
            }
            }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
          
                DataGridViewRow row = dgvPregledLookUp.SelectedRows[0];
                var properties = myProperty.GetType().GetProperties();

                string columnName = properties.Where(x => x.GetCustomAttribute<LookUpKeyAttribute>() != null)
                    .FirstOrDefault().GetCustomAttribute<SqlNameAttribute>().Naziv;

                Key = row.Cells[columnName].Value.ToString();

                columnName = properties.Where(x => x.GetCustomAttribute<LookUpValueAttribute>() != null)
                    .FirstOrDefault().GetCustomAttribute<SqlNameAttribute>().Naziv;

                Value = row.Cells[columnName].Value.ToString();

                this.Close();
            
        }
    }
}
