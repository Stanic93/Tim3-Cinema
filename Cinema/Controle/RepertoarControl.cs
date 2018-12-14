using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cinema.PropertyClass;
using System.Reflection;
using Cinema.AttributeClass;

namespace Cinema.Controle
{
    public partial class RepertoarControl : UserControl
    {
        bool selektovan = false;
        
        public RepertoarControl()
        {
            InitializeComponent();
            popuniPregled();
            prikaziKolone();
            dgvPregled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPregled.MultiSelect = false;
            popuniControle(new RepertoarPropertyClass());
        }

        private void popuniPregled()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = @"Select * from dbo.vRepertoar";
            command.Connection = connection;
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                reader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection");
            }
            dgvPregled.DataSource = dt;
        }

        private void prikaziKolone()
        {
            dgvPregled.Columns["FilmID"].Visible = false;
            dgvPregled.Columns["DatumPrvogPrikazivanja"].Visible = false;
            dgvPregled.Columns["DatumPosljednjegPrikazivanja"].Visible = false;
            dgvPregled.Columns["Aktivan"].Visible = false;
            dgvPregled.Columns["Reziser"].Visible = false;
            dgvPregled.Columns["Godina"].Width = 50;
            dgvPregled.Columns["Film"].Width = 145;



        }

        private void popuniControle(PropertyInterface property)
        {
            var properties = property.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                if(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Aktivan" || item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Film ID" || item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Godina")
                {
                    continue;
                }
                if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                {
                    RichTextBoxControl uc = new RichTextBoxControl();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    if (selektovan)
                        uc.SetVrijednost(item.GetValue(property).ToString());
                    flpDetaljno.Controls.Add(uc);
                    continue;
                }
                if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl uc = new DateTimeControl();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    DateTime date = new DateTime(2018, 12, 12);
                    uc.SetVrijednost(date);
                    flpDetaljno.Controls.Add(uc);
                    continue;
                }

                if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    if(selektovan)
                    uc.SetTextBox(item.GetValue(property).ToString());
                    flpDetaljno.Controls.Add(uc);
                }
            }
        }

        private void provjera()
        {
            if (dgvPregled.SelectedRows.Count == 0)
                return;
            string provjera = "";
            DataGridViewRow row = dgvPregled.SelectedRows[0];
            foreach(DataGridViewCell cell in row.Cells)
            {
                provjera += cell.Value.ToString() + " ";
            }

            MessageBox.Show(provjera);
        }

        private void dgvPregled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selektovan = true;
            PopulatePropertyInterface();
        }
        private void PopulatePropertyInterface()
        {
            PropertyInterface property = new RepertoarPropertyClass();
            DataGridViewRow row = dgvPregled.SelectedRows[0];
            var properties = property.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                string value = row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Naziv]
                    .Value.ToString();
                if(value != "")
                item.SetValue(property, Convert.ChangeType(value, item.PropertyType));
            }

            popuniControle(property);
        }
    }
}
