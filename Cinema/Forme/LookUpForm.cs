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
using Cinema.PropertyClass;

namespace Cinema
{
    public partial class LookUpForm : Form
    {
        public string Key;
        public string Value;
        PropertyInterface myProperty;
        public int terminID;
        public LookUpForm(PropertyInterface property)
        {
            InitializeComponent();
            myProperty = property;
            GetSelectAll();
        }
        public LookUpForm(PropertyInterface property,int termin)
        {
            InitializeComponent();
            myProperty = property;
            terminID = termin;
            GetSelectFreeSeat();
        }


        public void GetSelectAll()
        {
            //dgvPregledLookUp.DataSource = null;
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

        public void GetSelectFreeSeat()
        {
            DataTable dt = new DataTable();
            string connectionString = SqlHelper.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText =@" SELECT    s.BrojSjedista
                                    FROM dbo.Sjediste s
                                    WHERE s.SjedisteID NOT IN(SELECT k.SjedisteID
                                    FROM dbo.Racun r
                                    JOIN dbo.Karta k ON r.RacunID = k.RacunID
                                    WHERE k.TerminID = @terminID)";
            command.Connection = connection;
            SqlParameter parameter = new SqlParameter("@terminID", SqlDbType.SmallInt);
            parameter.Value = terminID;            
            command.Parameters.Add(parameter);
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
            catch
            {
                MessageBox.Show("Can not open connection");
            }
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
                if (dgvPregledLookUp.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvPregledLookUp.SelectedRows[0];
                    var properties = myProperty.GetType().GetProperties();

                    string columnName = properties.Where(x => x.GetCustomAttribute<LookUpKeyAttribute>() != null)
                        .FirstOrDefault().GetCustomAttribute<SqlNameAttribute>().Naziv;

                    Key = row.Cells[columnName].Value.ToString();

                    columnName = properties.Where(x => x.GetCustomAttribute<LookUpValueAttribute>() != null)
                    .FirstOrDefault().GetCustomAttribute<SqlNameAttribute>().Naziv;

                    if (columnName.Contains("ID"))
                    {
                        PropertyInterface foreignKeyInterface = Assembly.GetExecutingAssembly().
                                CreateInstance(properties.Where(x => x.GetCustomAttribute<ForeignKeyAttribute>() != null)
                            .FirstOrDefault().GetCustomAttribute<ForeignKeyAttribute>().className)
                                as PropertyInterface;

                        SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text,
                            foreignKeyInterface.GetLookUpQuery(row.Cells[1].Value.ToString()));

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();

                        dgvPregledLookUp.DataSource = dt;

                        row = dgvPregledLookUp.Rows[0];

                        Value = row.Cells[0].Value.ToString();

                    }
                    else if (columnName.Equals("Ime"))
                        Value = row.Cells[columnName].Value.ToString() +" "+ row.Cells["Prezime"].Value.ToString();
                    else
                        Value = row.Cells[columnName].Value.ToString();
                    DialogResult = DialogResult.OK;
                }
                else return;
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
