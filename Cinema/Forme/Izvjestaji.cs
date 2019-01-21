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
    public partial class Izvjestaji : Form
    {
        string[] Files;
        public Izvjestaji()
        {
            InitializeComponent();
            panelIzvjestaji.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbIzvjestaji.Items.Clear();
                Files = Directory.GetFiles(fbd.SelectedPath);

                foreach (string file in Files)
                {
                    if (Path.GetFileName(file).Contains(".rpt"))
                    lbIzvjestaji.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void lbIzvjestaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelIzvjestaji.Controls.Clear();
            CrystalReportViewer reportViewer = new CrystalReportViewer();
            panelIzvjestaji.Controls.Add(reportViewer);
            reportViewer.Dock = DockStyle.Fill;
            ReportDocument report = new ReportDocument();
            report.Load(@"" + Files[lbIzvjestaji.SelectedIndex]);
            report.SetDatabaseLogon("test_admin", "T3st@dm1n");
            reportViewer.ReportSource = report;
            reportViewer.Refresh();
        }
    }
}
