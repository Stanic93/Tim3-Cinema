using Cinema.AttributeClass;
using Cinema.Controle;
using Cinema.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Forme
{
    public partial class BlagajnaForm : Form
    {
        PropertyInterface property = new RepertoarPropertyClass();
        public BlagajnaForm()
        {
            InitializeComponent();
            popuniPregledRepertoar();
            prikaziKolone();
            dgvPregled.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPregled.MultiSelect = false;
            popuniRepertoarControle(property);
        }
        
        private void popuniPregledRepertoar()
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

        private void popuniRepertoarControle(PropertyInterface property)
        {
            var properties = property.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
            {
                if (item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Aktivan" || item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Film ID" || item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName == "Godina")
                {
                    continue;
                }
                if (item.GetCustomAttribute<RichTextBoxAttribute>() != null)
                {
                    RichTextBoxControl rc = new RichTextBoxControl();
                    rc.ReadOnly();
                    rc.Name = item.Name;
                    rc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(rc);
                    continue;
                }
                if (item.GetCustomAttribute<DateTimeAttribute>() != null)
                {
                    DateTimeControl dc = new DateTimeControl();
                    dc.ReadOnly();
                    dc.Name = item.Name;
                    dc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);                    
                    dc.SetVrijednost("01.01.2018");
                    flpDetaljno.Controls.Add(dc);
                    continue;
                }

                if (item.GetCustomAttribute<SqlNameAttribute>() != null)
                {
                    TextBoxControl uc = new TextBoxControl();
                    uc.ReadOnly();
                    uc.Name = item.Name;
                    uc.SetLabel(item.GetCustomAttributes<DisplayNameAttribute>().FirstOrDefault().DisplayName);
                    flpDetaljno.Controls.Add(uc);
                }
            }
        }

        private void dgvPregled_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulatePropertyInterface(property);
            popuniDetaljno(property);
            setujGraniceDatumProdukcije(property);
        }

        private void PopulatePropertyInterface(PropertyInterface property)
        {
            DataGridViewRow row = dgvPregled.SelectedRows[0];
            var properties = property.GetType().GetProperties();

            foreach (PropertyInfo item in properties)
            {
                string value = row.Cells[item.GetCustomAttribute<SqlNameAttribute>().Naziv]
                    .Value.ToString();
                if (item.GetCustomAttribute<SqlNameAttribute>().Naziv == "DuzinaTrajanja")
                {
                    TimeSpan time = TimeSpan.Parse(value);
                    item.SetValue(property, Convert.ChangeType(time, item.PropertyType));
                    continue;
                }
                if (value == "")
                {
                    value = "01.01.2018";
                }
                item.SetValue(property, Convert.ChangeType(value, item.PropertyType));
            }            
        }

        private void popuniDetaljno(PropertyInterface property)
        {
            var properties = property.GetType().GetProperties();
            foreach(PropertyInfo item in properties)
            {
                foreach(var item2 in flpDetaljno.Controls)
                {                   
                   if(item2.GetType() == typeof(TextBoxControl))
                    {                        
                        TextBoxControl tbc = item2 as TextBoxControl;
                        if(tbc.Name == item.Name)
                        {
                            tbc.SetTextBox(item.GetValue(property).ToString());
                        }
                    }
                    if (item2.GetType() == typeof(RichTextBoxControl))
                    {
                        RichTextBoxControl tbc = item2 as RichTextBoxControl;
                        if (tbc.Name == item.Name)
                        {
                            tbc.SetVrijednost(item.GetValue(property).ToString());
                        }
                    }
                    if (item2.GetType() == typeof(DateTimeControl))
                    {
                        DateTimeControl tbc = item2 as DateTimeControl;
                        if (tbc.Name == item.Name)
                        {
                            tbc.SetVrijednost(item.GetValue(property).ToString());
                        }
                    }
                }
            }
        }

        private void setujGraniceDatumProdukcije(PropertyInterface property)
        {
            DateTime dtMin = new DateTime(2018,01,01);
            DateTime dtMax = new DateTime(2018,10,01);
            
            string nesto = dgvPregled.SelectedRows[0].Cells["DatumPrvogPrikazivanja"].Value.ToString();

            if (dgvPregled.SelectedRows[0].Cells["DatumPrvogPrikazivanja"].Value.ToString() != "")
            {
                dtMin = Convert.ToDateTime(dgvPregled.SelectedRows[0].Cells["DatumPrvogPrikazivanja"].Value.ToString());
                dtMax = Convert.ToDateTime(dgvPregled.SelectedRows[0].Cells["DatumPosljednjegPrikazivanja"].Value.ToString());
            }

            if(dtMin > dtpDatumProdukcije.MaxDate)
            {

                dtpDatumProdukcije.MaxDate = dtMax;
                dtpDatumProdukcije.MinDate = dtMin;
            }
            else
            {
                dtpDatumProdukcije.MinDate = dtMin;
                dtpDatumProdukcije.MaxDate = dtMax;
            }

            dtpDatumProdukcije.Value = dtMin;
            
           
            
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            popuniPregledRepertoar();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = @"Select * from dbo.vRepertoar where Film Like '%'+@Naziv+'%'";
            command.Connection = connection;
            SqlParameter parameter = new SqlParameter("@Naziv", SqlDbType.NVarChar);
            parameter.Value = txtNaziv.Text;
            command.Parameters.Add(parameter);
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

            prikaziKolone();
        }
    }

}

