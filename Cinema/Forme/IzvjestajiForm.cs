
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Forme
{
    public partial class IzvjestajiForm : Form
    {
        List<string> Files;
        public IzvjestajiForm()
        {
            InitializeComponent();
            panelIzvjestaji.BackColor = Color.White;
        }
        public IzvjestajiForm(int RacunID)
        {
            InitializeComponent();
            panelIzvjestaji.BackColor = Color.White;
            panelUcitajIzvjestaje.Visible = false;
            panelIzvjestaji.Dock = DockStyle.Fill;
            CrystalReportViewer reportViewer = new CrystalReportViewer();
            panelIzvjestaji.Controls.Add(reportViewer);
            reportViewer.Dock = DockStyle.Fill;
            ReportDocument report = new ReportDocument();
            try
            {
                report.Load(Application.StartupPath+"/CinemaReports/RacunReport_NS.rpt");
                report.SetDatabaseLogon("bioskop_admin", "bioskop.123");
                report.SetParameterValue("@racunID", RacunID);
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
                MessageBox.Show("Baza nije verifikovana, provjerite svoju ODBC konekciju");
            }
            reportViewer.ReportSource = report;
            reportViewer.Refresh();

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            Files = new List<string>();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbIzvjestaji.Items.Clear();
                string[] pom = Directory.GetFiles(fbd.SelectedPath);
                int i = 0;
                foreach (string file in pom)
                {
                    if (Path.GetFileName(file).Contains(".rpt"))
                    {
                        lbIzvjestaji.Items.Add(Path.GetFileName(file));
                        Files.Add(file);
                    }
                }
            }
            if (Files.Count == 0)
            {
                lbIzvjestaji.Text = "Lista je prazna,u odabranom folderu nema .rpt fajlova.";
                MessageBox.Show("Odabrani folder ne sadrzi ni jedan Crystal reports izvjestaj!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbIzvjestaji_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbIzvjestaji.SelectedIndex != null)
                {
                    panelIzvjestaji.Controls.Clear();
                    CrystalReportViewer reportViewer = new CrystalReportViewer();
                    panelIzvjestaji.Controls.Add(reportViewer);
                    reportViewer.Dock = DockStyle.Fill;
                    ReportDocument report = new ReportDocument();
                    try
                    {
                        report.Load(@"" + Files.ElementAt(lbIzvjestaji.SelectedIndex));
                        report.SetDatabaseLogon("bioskop_admin", "bioskop.123");
                    }
                    catch (Exception r)
                    {
                        MessageBox.Show(r.Message);
                        MessageBox.Show("Putanja fajla: " + Files[lbIzvjestaji.SelectedIndex].ToString());
                    }
                    reportViewer.ReportSource = report;
                    reportViewer.Refresh();
                }
            }
            catch 
            {
                MessageBox.Show("Nije selektovan nijedan izvjestaj! ");
            }
        }
    }
}
