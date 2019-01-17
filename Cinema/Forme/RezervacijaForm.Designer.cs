namespace Cinema.Forme
{
    partial class RezervacijaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervacijaForm));
            this.tabControlRezervacija = new System.Windows.Forms.TabControl();
            this.tabPageRezervacija = new System.Windows.Forms.TabPage();
            this.lblStatusPrikaza = new System.Windows.Forms.Label();
            this.dgvPregledRezervacija = new System.Windows.Forms.DataGridView();
            this.tabPageRezervacijaDetaljno = new System.Windows.Forms.TabPage();
            this.dgvDetaljnoRezervacija = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnDodaj = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIzmijeni = new System.Windows.Forms.ToolStripButton();
            this.tsbtnObrisi = new System.Windows.Forms.ToolStripButton();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.panelPretraga = new System.Windows.Forms.Panel();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnPrebaciNaRacun = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.lblTermin = new System.Windows.Forms.Label();
            this.panelKarta = new System.Windows.Forms.Panel();
            this.txtVrijemeIzdavanja = new System.Windows.Forms.TextBox();
            this.lblVrijemeIzdavanja = new System.Windows.Forms.Label();
            this.txtSjedisteValue = new System.Windows.Forms.TextBox();
            this.btnFindSjediste = new System.Windows.Forms.Button();
            this.txtSjedisteKey = new System.Windows.Forms.TextBox();
            this.lblSjedisteID = new System.Windows.Forms.Label();
            this.txtValueRezervacija = new System.Windows.Forms.TextBox();
            this.btnFindRezervacija = new System.Windows.Forms.Button();
            this.txtKeyRezervacija = new System.Windows.Forms.TextBox();
            this.lblRezervacijaID = new System.Windows.Forms.Label();
            this.txtValueProjekcija = new System.Windows.Forms.TextBox();
            this.btnFindProjekcija = new System.Windows.Forms.Button();
            this.txtKeyProjekcija = new System.Windows.Forms.TextBox();
            this.lblProjekcija = new System.Windows.Forms.Label();
            this.txtValueTermin = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtKeyTermin = new System.Windows.Forms.TextBox();
            this.lblTerminID = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.panelNazivRezervacije = new System.Windows.Forms.Panel();
            this.lblNazivRezervacije = new System.Windows.Forms.Label();
            this.lblRezervacija = new System.Windows.Forms.Label();
            this.tabControlRezervacija.SuspendLayout();
            this.tabPageRezervacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledRezervacija)).BeginInit();
            this.tabPageRezervacijaDetaljno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljnoRezervacija)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelPretraga.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelKarta.SuspendLayout();
            this.panelNazivRezervacije.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRezervacija
            // 
            this.tabControlRezervacija.Controls.Add(this.tabPageRezervacija);
            this.tabControlRezervacija.Controls.Add(this.tabPageRezervacijaDetaljno);
            this.tabControlRezervacija.Location = new System.Drawing.Point(13, 31);
            this.tabControlRezervacija.Name = "tabControlRezervacija";
            this.tabControlRezervacija.SelectedIndex = 0;
            this.tabControlRezervacija.Size = new System.Drawing.Size(660, 254);
            this.tabControlRezervacija.TabIndex = 0;
            this.tabControlRezervacija.SelectedIndexChanged += new System.EventHandler(this.tabControlRezervacija_SelectedIndexChanged);
            // 
            // tabPageRezervacija
            // 
            this.tabPageRezervacija.Controls.Add(this.lblStatusPrikaza);
            this.tabPageRezervacija.Controls.Add(this.dgvPregledRezervacija);
            this.tabPageRezervacija.Location = new System.Drawing.Point(4, 22);
            this.tabPageRezervacija.Name = "tabPageRezervacija";
            this.tabPageRezervacija.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRezervacija.Size = new System.Drawing.Size(652, 228);
            this.tabPageRezervacija.TabIndex = 0;
            this.tabPageRezervacija.Text = "Rezervacije";
            this.tabPageRezervacija.UseVisualStyleBackColor = true;
            // 
            // lblStatusPrikaza
            // 
            this.lblStatusPrikaza.AutoSize = true;
            this.lblStatusPrikaza.Location = new System.Drawing.Point(14, 76);
            this.lblStatusPrikaza.Name = "lblStatusPrikaza";
            this.lblStatusPrikaza.Size = new System.Drawing.Size(255, 13);
            this.lblStatusPrikaza.TabIndex = 8;
            this.lblStatusPrikaza.Text = "Nema rezervacija za prikaz na selektovanom terminu";
            // 
            // dgvPregledRezervacija
            // 
            this.dgvPregledRezervacija.AllowUserToAddRows = false;
            this.dgvPregledRezervacija.AllowUserToDeleteRows = false;
            this.dgvPregledRezervacija.BackgroundColor = System.Drawing.Color.White;
            this.dgvPregledRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledRezervacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledRezervacija.Location = new System.Drawing.Point(3, 3);
            this.dgvPregledRezervacija.Name = "dgvPregledRezervacija";
            this.dgvPregledRezervacija.ReadOnly = true;
            this.dgvPregledRezervacija.Size = new System.Drawing.Size(646, 222);
            this.dgvPregledRezervacija.TabIndex = 0;
            this.dgvPregledRezervacija.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledRezervacija_CellDoubleClick);
            // 
            // tabPageRezervacijaDetaljno
            // 
            this.tabPageRezervacijaDetaljno.Controls.Add(this.dgvDetaljnoRezervacija);
            this.tabPageRezervacijaDetaljno.Controls.Add(this.toolStrip1);
            this.tabPageRezervacijaDetaljno.Location = new System.Drawing.Point(4, 22);
            this.tabPageRezervacijaDetaljno.Name = "tabPageRezervacijaDetaljno";
            this.tabPageRezervacijaDetaljno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRezervacijaDetaljno.Size = new System.Drawing.Size(652, 228);
            this.tabPageRezervacijaDetaljno.TabIndex = 1;
            this.tabPageRezervacijaDetaljno.Text = "Detaljno";
            this.tabPageRezervacijaDetaljno.UseVisualStyleBackColor = true;
            // 
            // dgvDetaljnoRezervacija
            // 
            this.dgvDetaljnoRezervacija.AllowUserToAddRows = false;
            this.dgvDetaljnoRezervacija.AllowUserToDeleteRows = false;
            this.dgvDetaljnoRezervacija.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetaljnoRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljnoRezervacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetaljnoRezervacija.Location = new System.Drawing.Point(3, 28);
            this.dgvDetaljnoRezervacija.Name = "dgvDetaljnoRezervacija";
            this.dgvDetaljnoRezervacija.ReadOnly = true;
            this.dgvDetaljnoRezervacija.Size = new System.Drawing.Size(646, 197);
            this.dgvDetaljnoRezervacija.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnDodaj,
            this.tsbtnIzmijeni,
            this.tsbtnObrisi});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(646, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStripMenu";
            // 
            // tsbtnDodaj
            // 
            this.tsbtnDodaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDodaj.Image")));
            this.tsbtnDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDodaj.Name = "tsbtnDodaj";
            this.tsbtnDodaj.Size = new System.Drawing.Size(23, 22);
            this.tsbtnDodaj.Text = "Dodaj";
            this.tsbtnDodaj.Click += new System.EventHandler(this.tsbtnDodaj_Click);
            // 
            // tsbtnIzmijeni
            // 
            this.tsbtnIzmijeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIzmijeni.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIzmijeni.Image")));
            this.tsbtnIzmijeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIzmijeni.Name = "tsbtnIzmijeni";
            this.tsbtnIzmijeni.Size = new System.Drawing.Size(23, 22);
            this.tsbtnIzmijeni.Text = "Izmijeni";
            this.tsbtnIzmijeni.Click += new System.EventHandler(this.tsbtnIzmijeni_Click);
            // 
            // tsbtnObrisi
            // 
            this.tsbtnObrisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnObrisi.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnObrisi.Image")));
            this.tsbtnObrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnObrisi.Name = "tsbtnObrisi";
            this.tsbtnObrisi.Size = new System.Drawing.Size(23, 22);
            this.tsbtnObrisi.Text = "Obrisi";
            this.tsbtnObrisi.Click += new System.EventHandler(this.tsbtnObrisi_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(3, 14);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(47, 13);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 37);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(162, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // panelPretraga
            // 
            this.panelPretraga.Controls.Add(this.btnPrikaziSve);
            this.panelPretraga.Controls.Add(this.btnPretrazi);
            this.panelPretraga.Controls.Add(this.lblPretraga);
            this.panelPretraga.Controls.Add(this.txtPretraga);
            this.panelPretraga.Location = new System.Drawing.Point(679, 56);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.Size = new System.Drawing.Size(171, 120);
            this.panelPretraga.TabIndex = 3;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(6, 92);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(162, 23);
            this.btnPrikaziSve.TabIndex = 4;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(6, 63);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(162, 23);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnPrebaciNaRacun);
            this.panelButton.Controls.Add(this.btnObrisi);
            this.panelButton.Location = new System.Drawing.Point(679, 182);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(171, 96);
            this.panelButton.TabIndex = 4;
            // 
            // btnPrebaciNaRacun
            // 
            this.btnPrebaciNaRacun.Location = new System.Drawing.Point(6, 55);
            this.btnPrebaciNaRacun.Name = "btnPrebaciNaRacun";
            this.btnPrebaciNaRacun.Size = new System.Drawing.Size(162, 32);
            this.btnPrebaciNaRacun.TabIndex = 1;
            this.btnPrebaciNaRacun.Text = "Prebaci na racun";
            this.btnPrebaciNaRacun.UseVisualStyleBackColor = true;
            this.btnPrebaciNaRacun.Click += new System.EventHandler(this.btnPrebaciNaRacun_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(6, 17);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(162, 32);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Location = new System.Drawing.Point(218, 13);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(35, 13);
            this.lblNazivFilma.TabIndex = 5;
            this.lblNazivFilma.Text = "label1";
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Location = new System.Drawing.Point(427, 13);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(35, 13);
            this.lblTermin.TabIndex = 6;
            this.lblTermin.Text = "label1";
            // 
            // panelKarta
            // 
            this.panelKarta.Controls.Add(this.txtVrijemeIzdavanja);
            this.panelKarta.Controls.Add(this.lblVrijemeIzdavanja);
            this.panelKarta.Controls.Add(this.txtSjedisteValue);
            this.panelKarta.Controls.Add(this.btnFindSjediste);
            this.panelKarta.Controls.Add(this.txtSjedisteKey);
            this.panelKarta.Controls.Add(this.lblSjedisteID);
            this.panelKarta.Controls.Add(this.txtValueRezervacija);
            this.panelKarta.Controls.Add(this.btnFindRezervacija);
            this.panelKarta.Controls.Add(this.txtKeyRezervacija);
            this.panelKarta.Controls.Add(this.lblRezervacijaID);
            this.panelKarta.Controls.Add(this.txtValueProjekcija);
            this.panelKarta.Controls.Add(this.btnFindProjekcija);
            this.panelKarta.Controls.Add(this.txtKeyProjekcija);
            this.panelKarta.Controls.Add(this.lblProjekcija);
            this.panelKarta.Controls.Add(this.txtValueTermin);
            this.panelKarta.Controls.Add(this.btnFind);
            this.panelKarta.Controls.Add(this.txtKeyTermin);
            this.panelKarta.Controls.Add(this.lblTerminID);
            this.panelKarta.Controls.Add(this.btnOdustani);
            this.panelKarta.Controls.Add(this.btnPotvrdi);
            this.panelKarta.Location = new System.Drawing.Point(17, 291);
            this.panelKarta.Name = "panelKarta";
            this.panelKarta.Size = new System.Drawing.Size(833, 94);
            this.panelKarta.TabIndex = 7;
            // 
            // txtVrijemeIzdavanja
            // 
            this.txtVrijemeIzdavanja.Location = new System.Drawing.Point(416, 13);
            this.txtVrijemeIzdavanja.Name = "txtVrijemeIzdavanja";
            this.txtVrijemeIzdavanja.ReadOnly = true;
            this.txtVrijemeIzdavanja.Size = new System.Drawing.Size(201, 20);
            this.txtVrijemeIzdavanja.TabIndex = 19;
            // 
            // lblVrijemeIzdavanja
            // 
            this.lblVrijemeIzdavanja.AutoSize = true;
            this.lblVrijemeIzdavanja.Location = new System.Drawing.Point(321, 15);
            this.lblVrijemeIzdavanja.Name = "lblVrijemeIzdavanja";
            this.lblVrijemeIzdavanja.Size = new System.Drawing.Size(89, 13);
            this.lblVrijemeIzdavanja.TabIndex = 18;
            this.lblVrijemeIzdavanja.Text = "Vrijeme izdavanja";
            // 
            // txtSjedisteValue
            // 
            this.txtSjedisteValue.Location = new System.Drawing.Point(500, 41);
            this.txtSjedisteValue.Name = "txtSjedisteValue";
            this.txtSjedisteValue.ReadOnly = true;
            this.txtSjedisteValue.Size = new System.Drawing.Size(117, 20);
            this.txtSjedisteValue.TabIndex = 17;
            // 
            // btnFindSjediste
            // 
            this.btnFindSjediste.Location = new System.Drawing.Point(459, 40);
            this.btnFindSjediste.Name = "btnFindSjediste";
            this.btnFindSjediste.Size = new System.Drawing.Size(38, 21);
            this.btnFindSjediste.TabIndex = 16;
            this.btnFindSjediste.Text = "...";
            this.btnFindSjediste.UseVisualStyleBackColor = true;
            this.btnFindSjediste.Click += new System.EventHandler(this.btnFindSjediste_Click);
            // 
            // txtSjedisteKey
            // 
            this.txtSjedisteKey.Location = new System.Drawing.Point(415, 40);
            this.txtSjedisteKey.Name = "txtSjedisteKey";
            this.txtSjedisteKey.ReadOnly = true;
            this.txtSjedisteKey.Size = new System.Drawing.Size(40, 20);
            this.txtSjedisteKey.TabIndex = 15;
            // 
            // lblSjedisteID
            // 
            this.lblSjedisteID.AutoSize = true;
            this.lblSjedisteID.Location = new System.Drawing.Point(321, 43);
            this.lblSjedisteID.Name = "lblSjedisteID";
            this.lblSjedisteID.Size = new System.Drawing.Size(58, 13);
            this.lblSjedisteID.TabIndex = 14;
            this.lblSjedisteID.Text = "Sjediste ID";
            // 
            // txtValueRezervacija
            // 
            this.txtValueRezervacija.Location = new System.Drawing.Point(181, 68);
            this.txtValueRezervacija.Name = "txtValueRezervacija";
            this.txtValueRezervacija.ReadOnly = true;
            this.txtValueRezervacija.Size = new System.Drawing.Size(117, 20);
            this.txtValueRezervacija.TabIndex = 13;
            // 
            // btnFindRezervacija
            // 
            this.btnFindRezervacija.Enabled = false;
            this.btnFindRezervacija.Location = new System.Drawing.Point(140, 67);
            this.btnFindRezervacija.Name = "btnFindRezervacija";
            this.btnFindRezervacija.Size = new System.Drawing.Size(38, 21);
            this.btnFindRezervacija.TabIndex = 12;
            this.btnFindRezervacija.Text = "...";
            this.btnFindRezervacija.UseVisualStyleBackColor = true;
            // 
            // txtKeyRezervacija
            // 
            this.txtKeyRezervacija.Location = new System.Drawing.Point(96, 67);
            this.txtKeyRezervacija.Name = "txtKeyRezervacija";
            this.txtKeyRezervacija.ReadOnly = true;
            this.txtKeyRezervacija.Size = new System.Drawing.Size(40, 20);
            this.txtKeyRezervacija.TabIndex = 11;
            // 
            // lblRezervacijaID
            // 
            this.lblRezervacijaID.AutoSize = true;
            this.lblRezervacijaID.Location = new System.Drawing.Point(14, 70);
            this.lblRezervacijaID.Name = "lblRezervacijaID";
            this.lblRezervacijaID.Size = new System.Drawing.Size(77, 13);
            this.lblRezervacijaID.TabIndex = 10;
            this.lblRezervacijaID.Text = "Rezervacija ID";
            // 
            // txtValueProjekcija
            // 
            this.txtValueProjekcija.Location = new System.Drawing.Point(181, 41);
            this.txtValueProjekcija.Name = "txtValueProjekcija";
            this.txtValueProjekcija.ReadOnly = true;
            this.txtValueProjekcija.Size = new System.Drawing.Size(117, 20);
            this.txtValueProjekcija.TabIndex = 9;
            // 
            // btnFindProjekcija
            // 
            this.btnFindProjekcija.Enabled = false;
            this.btnFindProjekcija.Location = new System.Drawing.Point(140, 40);
            this.btnFindProjekcija.Name = "btnFindProjekcija";
            this.btnFindProjekcija.Size = new System.Drawing.Size(38, 21);
            this.btnFindProjekcija.TabIndex = 8;
            this.btnFindProjekcija.Text = "...";
            this.btnFindProjekcija.UseVisualStyleBackColor = true;
            // 
            // txtKeyProjekcija
            // 
            this.txtKeyProjekcija.Location = new System.Drawing.Point(96, 40);
            this.txtKeyProjekcija.Name = "txtKeyProjekcija";
            this.txtKeyProjekcija.ReadOnly = true;
            this.txtKeyProjekcija.Size = new System.Drawing.Size(40, 20);
            this.txtKeyProjekcija.TabIndex = 7;
            // 
            // lblProjekcija
            // 
            this.lblProjekcija.AutoSize = true;
            this.lblProjekcija.Location = new System.Drawing.Point(14, 43);
            this.lblProjekcija.Name = "lblProjekcija";
            this.lblProjekcija.Size = new System.Drawing.Size(67, 13);
            this.lblProjekcija.TabIndex = 6;
            this.lblProjekcija.Text = "Projekcija ID";
            // 
            // txtValueTermin
            // 
            this.txtValueTermin.Location = new System.Drawing.Point(181, 13);
            this.txtValueTermin.Name = "txtValueTermin";
            this.txtValueTermin.ReadOnly = true;
            this.txtValueTermin.Size = new System.Drawing.Size(117, 20);
            this.txtValueTermin.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(140, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(38, 21);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtKeyTermin
            // 
            this.txtKeyTermin.Location = new System.Drawing.Point(96, 12);
            this.txtKeyTermin.Name = "txtKeyTermin";
            this.txtKeyTermin.ReadOnly = true;
            this.txtKeyTermin.Size = new System.Drawing.Size(40, 20);
            this.txtKeyTermin.TabIndex = 3;
            // 
            // lblTerminID
            // 
            this.lblTerminID.AutoSize = true;
            this.lblTerminID.Location = new System.Drawing.Point(14, 15);
            this.lblTerminID.Name = "lblTerminID";
            this.lblTerminID.Size = new System.Drawing.Size(53, 13);
            this.lblTerminID.TabIndex = 2;
            this.lblTerminID.Text = "Termin ID";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(668, 47);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(162, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(668, 18);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(162, 23);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // panelNazivRezervacije
            // 
            this.panelNazivRezervacije.Controls.Add(this.lblNazivRezervacije);
            this.panelNazivRezervacije.Controls.Add(this.lblRezervacija);
            this.panelNazivRezervacije.Location = new System.Drawing.Point(675, 56);
            this.panelNazivRezervacije.Name = "panelNazivRezervacije";
            this.panelNazivRezervacije.Size = new System.Drawing.Size(178, 46);
            this.panelNazivRezervacije.TabIndex = 9;
            this.panelNazivRezervacije.Visible = false;
            // 
            // lblNazivRezervacije
            // 
            this.lblNazivRezervacije.AutoSize = true;
            this.lblNazivRezervacije.Location = new System.Drawing.Point(82, 9);
            this.lblNazivRezervacije.Name = "lblNazivRezervacije";
            this.lblNazivRezervacije.Size = new System.Drawing.Size(35, 13);
            this.lblNazivRezervacije.TabIndex = 10;
            this.lblNazivRezervacije.Text = "label1";
            // 
            // lblRezervacija
            // 
            this.lblRezervacija.AutoSize = true;
            this.lblRezervacija.Location = new System.Drawing.Point(10, 9);
            this.lblRezervacija.Name = "lblRezervacija";
            this.lblRezervacija.Size = new System.Drawing.Size(66, 13);
            this.lblRezervacija.TabIndex = 10;
            this.lblRezervacija.Text = "Rezervacija:";
            // 
            // RezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 397);
            this.Controls.Add(this.panelNazivRezervacije);
            this.Controls.Add(this.panelKarta);
            this.Controls.Add(this.lblTermin);
            this.Controls.Add(this.lblNazivFilma);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelPretraga);
            this.Controls.Add(this.tabControlRezervacija);
            this.Name = "RezervacijaForm";
            this.Text = "RezervacijaForm";
            this.tabControlRezervacija.ResumeLayout(false);
            this.tabPageRezervacija.ResumeLayout(false);
            this.tabPageRezervacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledRezervacija)).EndInit();
            this.tabPageRezervacijaDetaljno.ResumeLayout(false);
            this.tabPageRezervacijaDetaljno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljnoRezervacija)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelKarta.ResumeLayout(false);
            this.panelKarta.PerformLayout();
            this.panelNazivRezervacije.ResumeLayout(false);
            this.panelNazivRezervacije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRezervacija;
        private System.Windows.Forms.TabPage tabPageRezervacija;
        private System.Windows.Forms.TabPage tabPageRezervacijaDetaljno;
        private System.Windows.Forms.DataGridView dgvPregledRezervacija;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnDodaj;
        private System.Windows.Forms.ToolStripButton tsbtnIzmijeni;
        private System.Windows.Forms.ToolStripButton tsbtnObrisi;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Panel panelPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnPrebaciNaRacun;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Label lblTermin;
        private System.Windows.Forms.Panel panelKarta;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox txtValueProjekcija;
        private System.Windows.Forms.Button btnFindProjekcija;
        private System.Windows.Forms.TextBox txtKeyProjekcija;
        private System.Windows.Forms.Label lblProjekcija;
        private System.Windows.Forms.TextBox txtValueTermin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtKeyTermin;
        private System.Windows.Forms.Label lblTerminID;
        private System.Windows.Forms.TextBox txtSjedisteValue;
        private System.Windows.Forms.Button btnFindSjediste;
        private System.Windows.Forms.TextBox txtSjedisteKey;
        private System.Windows.Forms.Label lblSjedisteID;
        private System.Windows.Forms.TextBox txtValueRezervacija;
        private System.Windows.Forms.Button btnFindRezervacija;
        private System.Windows.Forms.TextBox txtKeyRezervacija;
        private System.Windows.Forms.Label lblRezervacijaID;
        private System.Windows.Forms.Label lblVrijemeIzdavanja;
        private System.Windows.Forms.DataGridView dgvDetaljnoRezervacija;
        private System.Windows.Forms.TextBox txtVrijemeIzdavanja;
        private System.Windows.Forms.Label lblStatusPrikaza;
        private System.Windows.Forms.Panel panelNazivRezervacije;
        private System.Windows.Forms.Label lblNazivRezervacije;
        private System.Windows.Forms.Label lblRezervacija;
        private System.Windows.Forms.Button btnPrikaziSve;
    }
}