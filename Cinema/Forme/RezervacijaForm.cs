using Cinema.PropertyClass;
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
        int racunID;
        int zaposleniID;
        int rezervacijaID;
        string ProjekcijaID;
        State state;
        StateTab stateTab;
        public RezervacijaForm(int terminId, string nazivFilma, string vrijemeFilma, int zaposleniID,string fullName)
        {
            InitializeComponent();
            terminID = terminId;
            txtZaposleni.Text = fullName;
            this.zaposleniID = zaposleniID;
            lblNazivFilma.Text = nazivFilma;
            lblTermin.Text = vrijemeFilma;
            panelKarta.Visible = false;
            dgvPregledRezervacija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaljnoRezervacija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPregledRezervacija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaljnoRezervacija.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaljnoRezervacija.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPregledRezervacija.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDetaljnoRezervacija.RowHeadersVisible = false;
            dgvPregledRezervacija.RowHeadersVisible = false;
            dgvPregledRezervacija.AllowUserToResizeColumns = false;
            dgvPregledRezervacija.AllowUserToResizeRows = false;
            dgvDetaljnoRezervacija.AllowUserToResizeColumns = false;
            dgvDetaljnoRezervacija.AllowUserToResizeRows = false;
            dgvPregledRezervacija.MultiSelect = false;
            dgvDetaljnoRezervacija.MultiSelect = false;
            lblStatusPrikaza.Visible = false;
            panelOkvir.BorderStyle = BorderStyle.FixedSingle;
            
            popuniRezervacije();
            stateTab = StateTab.Rezervacija;
        }

        private void popuniRezervacije()
        {
            string commandText = @"exec proc_PopuniRezervacije @TerminID ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            SqlParameter parameter = new SqlParameter("@TerminID", SqlDbType.SmallInt);
            parameter.Value = terminID;
            parameters.Add(parameter);
            DataTable dt = Izvrsi(commandText, parameters);
            dgvPregledRezervacija.DataSource = dt;
            if (dgvPregledRezervacija.Rows.Count == 0)
            {
                lblStatusPrikaza.Visible = true;
                panelPretraga.Enabled = false;
                panelButton.Enabled = false;
                panel1.Visible = false;
                tabControlRezervacija.TabPages.RemoveAt(1);
            }
        }

        private DataTable Izvrsi(string commandText, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = connection;
            if (parameters.Count > 0)
            {
                for (int i = 0; i < parameters.Count; i++)
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
            string commandText = @"exec proc_PopuniRezervacijeDetaljno @RezervacijaID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = Convert.ToInt16(dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value.ToString());
                parameters.Add(parameter);
            }
            DataTable dt = Izvrsi(commandText, parameters);
            dgvDetaljnoRezervacija.DataSource = dt;
            if (dgvDetaljnoRezervacija.Rows.Count == 0)
            {
                tabControlRezervacija.SelectedTab = tabPageRezervacija;
                popuniRezervacije();
                return;
            }
            hideColumn(dgvDetaljnoRezervacija);
        }

        private void dgvPregledRezervacija_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlRezervacija.SelectedTab = tabPageRezervacijaDetaljno;
            lblNazivRezervacije.Text = dgvPregledRezervacija.SelectedRows[0].Cells["Naziv rezervacije"].Value.ToString();
        }

        private void tabControlRezervacija_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControlRezervacija.SelectedTab == tabPageRezervacijaDetaljno)
            {
                panelButton.Visible = false;
                panelPretraga.Visible = false;
                panelNazivRezervacije.Visible = true;
                popuniDetaljno();
                stateTab = StateTab.Detaljno;
                panelRacun.Visible = false;
            }
            else if (tabControlRezervacija.SelectedTab == tabPageRezervacija)
            {
                panelButton.Visible = true;
                panelPretraga.Visible = true;
                panelNazivRezervacije.Visible = false;
                stateTab = StateTab.Rezervacija;
                btnObrisi.Text = "Obrisi";
                btnPrebaciNaRacun.Text = "Prebaci na racun";
                panelRacun.Visible = false;
            }
            else
            {
                panelPretraga.Visible = false;
                panelButton.Visible = true;
                panelRacun.Visible = true;
            }
            if (dgvPregledRezervacija.SelectedRows.Count > 0)
            {
                lblNazivRezervacije.Text = dgvPregledRezervacija.SelectedRows[0].Cells["Naziv rezervacije"].Value.ToString();
            }
        }

        private void hideColumn(DataGridView dgv)
        {
            dgv.Columns["RezervacijaID"].Visible = false;
            dgv.Columns["ProjekcijaID"].Visible = false;
            dgv.Columns["TerminID"].Visible = false;
            dgv.Columns["SjedisteID"].Visible = false;
            dgv.Columns["VrijemePrikazivanja"].Visible = false;
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (txtPretraga.Text == "" || txtPretraga.Text == " ")
            {
                MessageBox.Show("Unesite string za pretragu");
                return;
            }
            string commandText = @"Select Distinct r.RezervacijaID,r.RezervacijaNaIme as [Naziv rezervacije]
                                        from Karta as k
                                        join Rezervacija as r
	                                            on k.RezervacijaID = r.RezervacijaID
                                        where (r.RezervacijaNaIme Like @RezervacijaNaIme+'%') and (TerminID = @TerminID)";
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
            if (dgvPregledRezervacija.Rows.Count == 0)
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

        private void tsbtnDodaj_Click(object sender, EventArgs e)
        {
            tabControlRezervacija.Enabled = false;
            panelKarta.Visible = true;
            state = State.Add;
            popuniKontroleKarte();
        }

        private void popuniKontroleKarte()
        {
            string terminID = dgvDetaljnoRezervacija.SelectedRows[0].Cells["TerminID"].Value.ToString();
            string vrijemePrikazivanja = dgvDetaljnoRezervacija.SelectedRows[0].Cells["VrijemePrikazivanja"].Value.ToString();
            string projekcijaID = dgvDetaljnoRezervacija.SelectedRows[0].Cells["ProjekcijaID"].Value.ToString();
            string rezervacijaID = dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value.ToString();
            string imeRez = dgvPregledRezervacija.SelectedRows[0].Cells["Naziv rezervacije"].Value.ToString();
            string brSjedista = "";
            string sjedisteID = "";
            if (state == State.Edit)
            {
                sjedisteID = dgvDetaljnoRezervacija.SelectedRows[0].Cells["SjedisteID"].Value.ToString();
                brSjedista = dgvDetaljnoRezervacija.SelectedRows[0].Cells["Broj sjedista"].Value.ToString();
            }
            txtKeyProjekcija.Text = projekcijaID;
            txtValueProjekcija.Text = lblNazivFilma.Text;
            txtKeyTermin.Text = terminID;
            txtValueTermin.Text = vrijemePrikazivanja;
            txtKeyRezervacija.Text = rezervacijaID;
            txtValueRezervacija.Text = imeRez;
            txtVrijemeIzdavanja.Text = Convert.ToString(DateTime.Now);
            if (state == State.Edit)
            {
                txtSjedisteKey.Text = sjedisteID;
                txtSjedisteValue.Text = brSjedista;
            }
        }

        private void dodajKartuNaRezervaciju()
        {
            string commandText = @"Insert into dbo.Karta (ProjekcijaID,VrijemeIzdavanja,SjedisteID,RezervacijaID,TerminID) 
                                    values (@ProjekcijaID,@VrijemeIzdavanja,@SjedisteID,@RezervacijaID,@TerminID)";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@ProjekcijaID", SqlDbType.SmallInt);
                parameter.Value = txtKeyProjekcija.Text;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@VrijemeIzdavanja", SqlDbType.DateTime);
                parameter.Value = txtVrijemeIzdavanja.Text;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", SqlDbType.SmallInt);
                parameter.Value = txtSjedisteKey.Text;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = txtKeyRezervacija.Text;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@TerminID", SqlDbType.SmallInt);
                parameter.Value = txtKeyTermin.Text;
                parameters.Add(parameter);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(commandText, parameters);
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (txtSjedisteKey.Text == "" || txtSjedisteKey.Text == " ")
            {
                MessageBox.Show("Unesite sjediste za rezervaciju");
                return;
            }
            if (state == State.Add)
            {
                dodajKartuNaRezervaciju();
            }
            else if (state == State.Edit)
            {
                IzmijeniKartuNaRezervaciji();
            }
            ocistiKontrole();
            popuniDetaljno();
            panelKarta.Visible = false;
            tabControlRezervacija.Enabled = true;
        }

        private void IzmijeniKartuNaRezervaciji()
        {
            string commandText = @"Update dbo.Karta Set 
                                                        SjedisteID = @SjedisteID
                                                        where KartaID = @KartaID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KartaID", SqlDbType.SmallInt);
                parameter.Value = dgvDetaljnoRezervacija.SelectedRows[0].Cells["KartaID"].Value.ToString();
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@SjedisteID", SqlDbType.SmallInt);
                parameter.Value = txtSjedisteKey.Text;
                parameters.Add(parameter);
            }
            Izvrsi(commandText, parameters);
        }

        private void ocistiKontrole()
        {
            txtKeyProjekcija.Text = "";
            txtValueProjekcija.Text = "";
            txtKeyTermin.Text = "";
            txtValueTermin.Text = "";
            txtKeyRezervacija.Text = "";
            txtValueRezervacija.Text = "";
            txtVrijemeIzdavanja.Text = "";
            txtSjedisteKey.Text = "";
            txtSjedisteValue.Text = "";

        }

        private void btnFindSjediste_Click(object sender, EventArgs e)
        {
            LookUpForm novaForma1 = new LookUpForm(new SjedistePropertyClass(), terminID);
            novaForma1.ShowDialog();
            txtSjedisteKey.Text = novaForma1.Key;
            txtSjedisteValue.Text = novaForma1.Value;
            return;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            ocistiKontrole();
            panelKarta.Visible = false;
            tabControlRezervacija.Enabled = true;
        }

        private void tsbtnIzmijeni_Click(object sender, EventArgs e)
        {
            state = State.Edit;
            panelKarta.Visible = true;
            tabControlRezervacija.Enabled = false;
            popuniKontroleKarte();
        }

        private void tsbtnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite obrisati kartu ?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ObrisiKartu();
            }
            MessageBox.Show("Karta obrisana");
            popuniDetaljno();
        }

        private void ObrisiKartu()
        {
            string commandtText = @"Delete dbo.Karta where KartaID = @KartaID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@KartaID", SqlDbType.SmallInt);
                parameter.Value = dgvDetaljnoRezervacija.SelectedRows[0].Cells["KartaID"].Value.ToString();
                parameters.Add(parameter);
            }
            Izvrsi(commandtText, parameters);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (stateTab == StateTab.Rezervacija)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da zelite da obrisete rezervaciju?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    obrisiKarteNaRezervaciji();
                    obrisiRezervaciju();
                    MessageBox.Show("Obrisali ste rezervaciju!");
                    popuniRezervacije();
                }
            }
            else if (stateTab == StateTab.Racun)
            {
                obrisiTab();
                tabControlRezervacija.Enabled = true;
            }
        }

        private void obrisiTab()
        {
            tabControlRezervacija.TabPages.RemoveAt(2);
        }

        private void obrisiKarteNaRezervaciji()
        {
            string commandText = @"Delete dbo.Karta where RezervacijaID = @RezervacijaID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value.ToString();
                parameters.Add(parameter);
            }
            Izvrsi(commandText, parameters);

        }

        private void obrisiRezervaciju()
        {
            List<SqlParameter> parametersRezervacija = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value.ToString();
                parametersRezervacija.Add(parameter);
            }

            string commandTextIzbrisiRezervaciju = @"Delete dbo.Rezervacija where RezervacijaID = @RezervacijaID";
            Izvrsi(commandTextIzbrisiRezervaciju, parametersRezervacija);
        }

        private void btnPrebaciNaRacun_Click(object sender, EventArgs e)
        {
            if (stateTab == StateTab.Rezervacija)
            {
                TabPage tab = new TabPage();
                tab.Name = "Racun";
                tab.Text = "Racun";
                tabControlRezervacija.Controls.Add(tab);
                tabControlRezervacija.SelectedTab = tab;
                tabControlRezervacija.Enabled = false;
                DataGridView dgv = new DataGridView();
                string commandText = @"Select  k.KartaID,k.RezervacijaID,k.ProjekcijaID,k.TerminID,t.VrijemePrikazivanja,k.SjedisteID,s.BrojSjedista as [Broj sjedista], k.VrijemeIzdavanja as [Vrijeme izdavanja],c.Cijena
                                    from dbo.Karta as k
                                    join dbo.Sjediste as s
                                    on k.SjedisteID = s.SjedisteID
                                    join dbo.Termin as t
                                    on k.TerminID = t.TerminID
                                    join dbo.Cijena as c
                                    on c.CijenaID = t.CijenaID
                                    where k.RezervacijaID = @RezervacijaID;";
                List<SqlParameter> parameters = new List<SqlParameter>();
                {
                    SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                    parameter.Value = Convert.ToInt16(dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value.ToString());
                    parameters.Add(parameter);
                }
                dgv.DataSource = Izvrsi(commandText, parameters);
                tab.Controls.Add(dgv);
                if (dgv.Rows.Count > 0)
                {
                    hideColumn(dgv);
                }
                panelPretraga.Visible = false;
                //dgv.Dock = DockStyle.Fill;
                btnObrisi.Text = "Odustani";
                btnPrebaciNaRacun.Text = "Stampaj racun";
                stateTab = StateTab.Racun;
                IzracunajSumuRacuna(dgv);
                formatiraj(dgv);
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.Dock = DockStyle.Fill;
                dgv.BackgroundColor = Color.White;
            }
            else if (stateTab == StateTab.Racun)
            {
                kreirajRacun();
                prebaciRezervacijuNaRacun();
                dodajCijenuNaRacun();
                obrisiTab();
                tabControlRezervacija.Enabled = true;
                popuniRezervacije();
            }
        }
        
        private void formatiraj(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 128);
                }
            }
        }

        private void prebaciRezervacijuNaRacun()
        {
            rezervacijaID = Convert.ToInt32(dgvPregledRezervacija.SelectedRows[0].Cells["RezervacijaID"].Value);
            string commandText = @"Update dbo.Karta set RezervacijaID = null,RacunID = @RacunID where RezervacijaID = @RezervacijaID ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@RezervacijaID", SqlDbType.SmallInt);
                parameter.Value = rezervacijaID;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("@RacunID", SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            DataTable dt = Izvrsi(commandText, parameters);
        }

        private void kreirajRacun()
        {

            SqlConnection connection = new SqlConnection(SqlHelper.GetConnectionString());
            SqlCommand command = new SqlCommand();
            command.CommandText = @"INSERT into dbo.Racun (DatumIzdavanja, ZaposleniID, UkupnaCijena) values (GetDate(), @ZaposleniID, null)";
            command.Connection = connection;
            SqlParameter parameter = new SqlParameter("@ZaposleniID", SqlDbType.SmallInt);
            parameter.Value = zaposleniID;
            command.Parameters.Add(parameter);
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
            RacunPropertyClass pomocni = new RacunPropertyClass();
            SqlDataReader reader1 = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, pomocni.GetMaxIDQuery());
            DataTable dt1 = new DataTable();

            dt1.Load(reader1);
            foreach (DataRow row in dt1.Rows)
            {

                racunID = row.Field<short>("RacunID");
            }
            reader1.Close();
        }

        private void IzracunajSumuRacuna(DataGridView dgv)
        {
            decimal cijena = 0;
            for(int i=0; i<dgv.Rows.Count-1; i++)
            {
                if (dgv.Rows[i].Cells["Cijena"].Value.ToString() != null)
                {
                    string cijenaPolje = dgv.Rows[i].Cells["Cijena"].Value.ToString();
                    cijena += Convert.ToDecimal(cijenaPolje);
                }
            }
            txtUkupnaVrijednost.Text = "" + cijena;
            txtUkupnaVrijednost.ReadOnly = true;            
        }
        private void dodajCijenuNaRacun()
        {
            string command = "Update dbo.Racun set UkupnaCijena = @Ukupno where RacunID = @RacunID";
            List<SqlParameter> parameters = new List<SqlParameter>();
            {
                SqlParameter parameter = new SqlParameter("@Ukupno", SqlDbType.Int);
                decimal nesto = Convert.ToDecimal(txtUkupnaVrijednost.Text);
                int broj = Convert.ToInt32(nesto);
                parameter.Value = broj;
                parameters.Add(parameter);
            }
            {
                SqlParameter parameter = new SqlParameter("RacunID", SqlDbType.SmallInt);
                parameter.Value = racunID;
                parameters.Add(parameter);
            }
            DataTable dt = new DataTable();
            dt = Izvrsi(command, parameters);
        }

        private void dgvPregledRezervacija_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvPregledRezervacija.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dgvPregledRezervacija.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 128);
                }
            }
        }

        private void dgvDetaljnoRezervacija_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvDetaljnoRezervacija.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dgvDetaljnoRezervacija.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 128);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
