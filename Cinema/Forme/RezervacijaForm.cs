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

namespace Cinema.Forme
{
    public partial class RezervacijaForm : Form
    {
        int terminID;
        public RezervacijaForm(int terminId, string nazivFilma, string vrijemeFilma)
        {
            InitializeComponent();
            terminID = terminId;
            lblNazivFilma.Text = nazivFilma;
            lblTermin.Text = vrijemeFilma;
            panelKarta.Visible = false;            
            dgvPregledRezervacija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaljnoRezervacija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblStatusPrikaza.Visible = false;
            popuniRezervacije();
        }

        private void popuniRezervacije()
        {
            string commandText = @"Select Distinct r.RezervacijaID,r.RezervacijaNaIme as [Naziv rezervacije]
                                        from Karta as k
                                        join Rezervacija as r
	                                            on k.RezervacijaID = r.RezervacijaID
                                        where (k.RezervacijaID is not null) and (TerminID = @TerminID) ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("@TerminID", SqlDbType.SmallInt);
            parameter.Value = terminID;
            parameters.Add(parameter);
            DataTable  dt = Izvrsi(commandText, parameters);
            dgvPregledRezervacija.DataSource = dt;
            if(dgvPregledRezervacija.Rows.Count == 0)
            {
                lblStatusPrikaza.Visible = true;
                panelPretraga.Enabled = false;
                panelButton.Enabled = false;
                toolStrip1.Visible = false;
                tabControlRezervacija.TabPages.RemoveAt(1);

            }
        }

        private DataTable Izvrsi(string commandText, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = connection;
            if(parameters.Count > 0)
            {
                for(int i=0; i<parameters.Count; i++)
                {
                    command.Parameters.Add(parameters[i]);
                }
            }
            SqlDataReader reader;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                dt.Load(reader);
                connection.Close();
                reader.Close();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("Can not open connection");
            }
            return dt;
        }
        
        private void popuniDetaljno()
        {
            string commandText = @"Select  k.KartaID,k.RezervacijaID,k.ProjekcijaID,k.TerminID,k.SjedisteID,s.BrojSjedista as [Broj sjedista], k.VrijemeIzdavanja as [Vrijeme izdavanja]
                                    from dbo.Karta as k
                                    join dbo.Sjediste as s
                                    on k.SjedisteID = s.SjedisteID
                                    where k.RezervacijaID = @RezervacijaID;";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = Convert.ToInt16( dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value.ToString());
                parameters.Add(parameter);
            }
            DataTable dt = Izvrsi(commandText, parameters);
            dgvDetaljnoRezervacija.DataSource = dt;
            hideColumn();
        }

        private void dgvPregledRezervacija_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            popuniDetaljno();
            tabControlRezervacija.SelectedTab = tabPageRezervacijaDetaljno;
            lblNazivRezervacije.Text = dgvPregledRezervacija.SelectedRows[0].Cells["Naziv rezervacije"].Value.ToString();
        }

        private void tabControlRezervacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlRezervacija.SelectedTab == tabPageRezervacijaDetaljno)
            {
                panelButton.Visible = false;
                panelPretraga.Visible = false;
                panelNazivRezervacije.Visible = true;
            }
            else
            {
                panelButton.Visible = true;
                panelPretraga.Visible = true;
                panelNazivRezervacije.Visible = false;
            }
        }

        private void dgvPregledRezervacija_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            popuniDetaljno();

        }

        private void hideColumn()
        {
            dgvDetaljnoRezervacija.Columns["RezervacijaID"].Visible = false;
            dgvDetaljnoRezervacija.Columns["ProjekcijaID"].Visible = false;
            dgvDetaljnoRezervacija.Columns["TerminID"].Visible = false;
            dgvDetaljnoRezervacija.Columns["SjedisteID"].Visible = false;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if(txtPretraga.Text == "" || txtPretraga.Text == " ")
            {
                MessageBox.Show("Unesite string za pretragu");
                return;
            }
            string commandText = @"Select Distinct r.RezervacijaID,r.RezervacijaNaIme as [Naziv rezervacije]
                                        from Karta as k
                                        join Rezervacija as r
	                                            on k.RezervacijaID = r.RezervacijaID
                                        where (r.RezervacijaNaIme Like '%'+@RezervacijaNaIme+'%') and (TerminID = @TerminID)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaNaIme", SqlDbType.NVarChar);
                parameter.Value = txtPretraga.Text;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@TerminID", SqlDbType.SmallInt);
                parameter.Value = terminID;
                parameters.Add(parameter);
            }
            DataTable dt = Izvrsi(commandText, parameters);
            dgvPregledRezervacija.DataSource = dt;
            if(dgvPregledRezervacija.Rows.Count == 0)
            {
                popuniRezervacije();
                MessageBox.Show("Nema rezervacija");
            }
            else
            {
                txtPretraga.Text = "";
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            popuniRezervacije();
            txtPretraga.Text = "";
        }
    }
}
