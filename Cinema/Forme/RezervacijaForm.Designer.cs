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
            this.tabControlRezervacija = new System.Windows.Forms.TabControl();
            this.tabPageRezervacija = new System.Windows.Forms.TabPage();
            this.lblStatusPrikaza = new System.Windows.Forms.Label();
            this.dgvPregledRezervacija = new System.Windows.Forms.DataGridView();
            this.tabPageRezervacijaDetaljno = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsbtnObrisi = new System.Windows.Forms.Button();
            this.tsbtnIzmijeni = new System.Windows.Forms.Button();
            this.tsbtnDodaj = new System.Windows.Forms.Button();
            this.dgvDetaljnoRezervacija = new System.Windows.Forms.DataGridView();
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
            this.panelRacun = new System.Windows.Forms.Panel();
            this.txtZaposleni = new System.Windows.Forms.TextBox();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.txtUkupnaVrijednost = new System.Windows.Forms.TextBox();
            this.lblVrijednostRacuna = new System.Windows.Forms.Label();
            this.lblNazivRezervacije = new System.Windows.Forms.Label();
            this.lblRezervacija = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelOkvir = new System.Windows.Forms.Panel();
            this.tabControlRezervacija.SuspendLayout();
            this.tabPageRezervacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledRezervacija)).BeginInit();
            this.tabPageRezervacijaDetaljno.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljnoRezervacija)).BeginInit();
            this.panelPretraga.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelKarta.SuspendLayout();
            this.panelNazivRezervacije.SuspendLayout();
            this.panelRacun.SuspendLayout();
            this.panelOkvir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRezervacija
            // 
            this.tabControlRezervacija.Controls.Add(this.tabPageRezervacija);
            this.tabControlRezervacija.Controls.Add(this.tabPageRezervacijaDetaljno);
            this.tabControlRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlRezervacija.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRezervacija.Location = new System.Drawing.Point(17, 31);
            this.tabControlRezervacija.Name = "tabControlRezervacija";
            this.tabControlRezervacija.SelectedIndex = 0;
            this.tabControlRezervacija.Size = new System.Drawing.Size(651, 254);
            this.tabControlRezervacija.TabIndex = 0;
            this.tabControlRezervacija.SelectedIndexChanged += new System.EventHandler(this.tabControlRezervacija_SelectedIndexChanged);
            // 
            // tabPageRezervacija
            // 
            this.tabPageRezervacija.Controls.Add(this.lblStatusPrikaza);
            this.tabPageRezervacija.Controls.Add(this.dgvPregledRezervacija);
            this.tabPageRezervacija.Location = new System.Drawing.Point(4, 25);
            this.tabPageRezervacija.Name = "tabPageRezervacija";
            this.tabPageRezervacija.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRezervacija.Size = new System.Drawing.Size(643, 225);
            this.tabPageRezervacija.TabIndex = 0;
            this.tabPageRezervacija.Text = "Rezervacije";
            this.tabPageRezervacija.UseVisualStyleBackColor = true;
            // 
            // lblStatusPrikaza
            // 
            this.lblStatusPrikaza.AutoSize = true;
            this.lblStatusPrikaza.Location = new System.Drawing.Point(14, 76);
            this.lblStatusPrikaza.Name = "lblStatusPrikaza";
            this.lblStatusPrikaza.Size = new System.Drawing.Size(294, 16);
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
            this.dgvPregledRezervacija.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPregledRezervacija.Size = new System.Drawing.Size(637, 219);
            this.dgvPregledRezervacija.TabIndex = 0;
            this.dgvPregledRezervacija.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledRezervacija_CellDoubleClick);
            this.dgvPregledRezervacija.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPregledRezervacija_CellFormatting);
            // 
            // tabPageRezervacijaDetaljno
            // 
            this.tabPageRezervacijaDetaljno.Controls.Add(this.panel1);
            this.tabPageRezervacijaDetaljno.Controls.Add(this.dgvDetaljnoRezervacija);
            this.tabPageRezervacijaDetaljno.Location = new System.Drawing.Point(4, 25);
            this.tabPageRezervacijaDetaljno.Name = "tabPageRezervacijaDetaljno";
            this.tabPageRezervacijaDetaljno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRezervacijaDetaljno.Size = new System.Drawing.Size(643, 225);
            this.tabPageRezervacijaDetaljno.TabIndex = 1;
            this.tabPageRezervacijaDetaljno.Text = "Detaljno";
            this.tabPageRezervacijaDetaljno.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.tsbtnObrisi);
            this.panel1.Controls.Add(this.tsbtnIzmijeni);
            this.panel1.Controls.Add(this.tsbtnDodaj);
            this.panel1.Location = new System.Drawing.Point(-9, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 29);
            this.panel1.TabIndex = 2;
            // 
            // tsbtnObrisi
            // 
            this.tsbtnObrisi.BackgroundImage = global::Cinema.Properties.Resources.delete;
            this.tsbtnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tsbtnObrisi.FlatAppearance.BorderSize = 0;
            this.tsbtnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnObrisi.Location = new System.Drawing.Point(86, 4);
            this.tsbtnObrisi.Name = "tsbtnObrisi";
            this.tsbtnObrisi.Size = new System.Drawing.Size(31, 22);
            this.tsbtnObrisi.TabIndex = 2;
            this.tsbtnObrisi.UseVisualStyleBackColor = true;
            this.tsbtnObrisi.Click += new System.EventHandler(this.tsbtnObrisi_Click);
            // 
            // tsbtnIzmijeni
            // 
            this.tsbtnIzmijeni.BackgroundImage = global::Cinema.Properties.Resources.pencil_edit_button;
            this.tsbtnIzmijeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
            this.tsbtnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnIzmijeni.Location = new System.Drawing.Point(49, 4);
            this.tsbtnIzmijeni.Name = "tsbtnIzmijeni";
            this.tsbtnIzmijeni.Size = new System.Drawing.Size(31, 22);
            this.tsbtnIzmijeni.TabIndex = 1;
            this.tsbtnIzmijeni.UseVisualStyleBackColor = true;
            this.tsbtnIzmijeni.Click += new System.EventHandler(this.tsbtnIzmijeni_Click);
            // 
            // tsbtnDodaj
            // 
            this.tsbtnDodaj.BackgroundImage = global::Cinema.Properties.Resources.add;
            this.tsbtnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tsbtnDodaj.FlatAppearance.BorderSize = 0;
            this.tsbtnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnDodaj.Location = new System.Drawing.Point(11, 4);
            this.tsbtnDodaj.Name = "tsbtnDodaj";
            this.tsbtnDodaj.Size = new System.Drawing.Size(31, 22);
            this.tsbtnDodaj.TabIndex = 0;
            this.tsbtnDodaj.UseVisualStyleBackColor = true;
            this.tsbtnDodaj.Click += new System.EventHandler(this.tsbtnDodaj_Click);
            // 
            // dgvDetaljnoRezervacija
            // 
            this.dgvDetaljnoRezervacija.AllowUserToAddRows = false;
            this.dgvDetaljnoRezervacija.AllowUserToDeleteRows = false;
            this.dgvDetaljnoRezervacija.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetaljnoRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljnoRezervacija.Location = new System.Drawing.Point(0, 28);
            this.dgvDetaljnoRezervacija.Name = "dgvDetaljnoRezervacija";
            this.dgvDetaljnoRezervacija.ReadOnly = true;
            this.dgvDetaljnoRezervacija.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvDetaljnoRezervacija.Size = new System.Drawing.Size(647, 197);
            this.dgvDetaljnoRezervacija.TabIndex = 1;
            this.dgvDetaljnoRezervacija.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDetaljnoRezervacija_CellFormatting);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.White;
            this.lblPretraga.Location = new System.Drawing.Point(3, 14);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(64, 17);
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
            this.btnPrikaziSve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnPrikaziSve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrikaziSve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziSve.ForeColor = System.Drawing.Color.White;
            this.btnPrikaziSve.Location = new System.Drawing.Point(3, 96);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(162, 23);
            this.btnPrikaziSve.TabIndex = 4;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = false;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnPretrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretrazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPretrazi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(3, 67);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(162, 23);
            this.btnPretrazi.TabIndex = 3;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = false;
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
            this.btnPrebaciNaRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnPrebaciNaRacun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrebaciNaRacun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrebaciNaRacun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrebaciNaRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrebaciNaRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrebaciNaRacun.ForeColor = System.Drawing.Color.White;
            this.btnPrebaciNaRacun.Location = new System.Drawing.Point(6, 55);
            this.btnPrebaciNaRacun.Name = "btnPrebaciNaRacun";
            this.btnPrebaciNaRacun.Size = new System.Drawing.Size(162, 32);
            this.btnPrebaciNaRacun.TabIndex = 1;
            this.btnPrebaciNaRacun.Text = "Prebaci na račun";
            this.btnPrebaciNaRacun.UseVisualStyleBackColor = false;
            this.btnPrebaciNaRacun.Click += new System.EventHandler(this.btnPrebaciNaRacun_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(6, 17);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(162, 32);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivFilma.ForeColor = System.Drawing.Color.White;
            this.lblNazivFilma.Location = new System.Drawing.Point(218, 13);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(58, 19);
            this.lblNazivFilma.TabIndex = 5;
            this.lblNazivFilma.Text = "label1";
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermin.ForeColor = System.Drawing.Color.White;
            this.lblTermin.Location = new System.Drawing.Point(427, 13);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(58, 19);
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
            this.txtVrijemeIzdavanja.Location = new System.Drawing.Point(438, 13);
            this.txtVrijemeIzdavanja.Name = "txtVrijemeIzdavanja";
            this.txtVrijemeIzdavanja.ReadOnly = true;
            this.txtVrijemeIzdavanja.Size = new System.Drawing.Size(201, 20);
            this.txtVrijemeIzdavanja.TabIndex = 19;
            // 
            // lblVrijemeIzdavanja
            // 
            this.lblVrijemeIzdavanja.AutoSize = true;
            this.lblVrijemeIzdavanja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemeIzdavanja.ForeColor = System.Drawing.Color.White;
            this.lblVrijemeIzdavanja.Location = new System.Drawing.Point(321, 15);
            this.lblVrijemeIzdavanja.Name = "lblVrijemeIzdavanja";
            this.lblVrijemeIzdavanja.Size = new System.Drawing.Size(115, 17);
            this.lblVrijemeIzdavanja.TabIndex = 18;
            this.lblVrijemeIzdavanja.Text = "Vrijeme izdavanja";
            // 
            // txtSjedisteValue
            // 
            this.txtSjedisteValue.Location = new System.Drawing.Point(522, 41);
            this.txtSjedisteValue.Name = "txtSjedisteValue";
            this.txtSjedisteValue.ReadOnly = true;
            this.txtSjedisteValue.Size = new System.Drawing.Size(117, 20);
            this.txtSjedisteValue.TabIndex = 17;
            // 
            // btnFindSjediste
            // 
            this.btnFindSjediste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFindSjediste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindSjediste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindSjediste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFindSjediste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSjediste.ForeColor = System.Drawing.Color.White;
            this.btnFindSjediste.Location = new System.Drawing.Point(481, 40);
            this.btnFindSjediste.Name = "btnFindSjediste";
            this.btnFindSjediste.Size = new System.Drawing.Size(38, 21);
            this.btnFindSjediste.TabIndex = 16;
            this.btnFindSjediste.Text = "...";
            this.btnFindSjediste.UseVisualStyleBackColor = false;
            this.btnFindSjediste.Click += new System.EventHandler(this.btnFindSjediste_Click);
            // 
            // txtSjedisteKey
            // 
            this.txtSjedisteKey.Location = new System.Drawing.Point(437, 40);
            this.txtSjedisteKey.Name = "txtSjedisteKey";
            this.txtSjedisteKey.ReadOnly = true;
            this.txtSjedisteKey.Size = new System.Drawing.Size(40, 20);
            this.txtSjedisteKey.TabIndex = 15;
            // 
            // lblSjedisteID
            // 
            this.lblSjedisteID.AutoSize = true;
            this.lblSjedisteID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSjedisteID.ForeColor = System.Drawing.Color.White;
            this.lblSjedisteID.Location = new System.Drawing.Point(321, 43);
            this.lblSjedisteID.Name = "lblSjedisteID";
            this.lblSjedisteID.Size = new System.Drawing.Size(70, 17);
            this.lblSjedisteID.TabIndex = 14;
            this.lblSjedisteID.Text = "Sjediste ID";
            // 
            // txtValueRezervacija
            // 
            this.txtValueRezervacija.Location = new System.Drawing.Point(191, 68);
            this.txtValueRezervacija.Name = "txtValueRezervacija";
            this.txtValueRezervacija.ReadOnly = true;
            this.txtValueRezervacija.Size = new System.Drawing.Size(117, 20);
            this.txtValueRezervacija.TabIndex = 13;
            // 
            // btnFindRezervacija
            // 
            this.btnFindRezervacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFindRezervacija.Enabled = false;
            this.btnFindRezervacija.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindRezervacija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindRezervacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindRezervacija.ForeColor = System.Drawing.Color.White;
            this.btnFindRezervacija.Location = new System.Drawing.Point(150, 67);
            this.btnFindRezervacija.Name = "btnFindRezervacija";
            this.btnFindRezervacija.Size = new System.Drawing.Size(38, 21);
            this.btnFindRezervacija.TabIndex = 12;
            this.btnFindRezervacija.Text = "...";
            this.btnFindRezervacija.UseVisualStyleBackColor = false;
            // 
            // txtKeyRezervacija
            // 
            this.txtKeyRezervacija.Location = new System.Drawing.Point(106, 67);
            this.txtKeyRezervacija.Name = "txtKeyRezervacija";
            this.txtKeyRezervacija.ReadOnly = true;
            this.txtKeyRezervacija.Size = new System.Drawing.Size(40, 20);
            this.txtKeyRezervacija.TabIndex = 11;
            // 
            // lblRezervacijaID
            // 
            this.lblRezervacijaID.AutoSize = true;
            this.lblRezervacijaID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervacijaID.ForeColor = System.Drawing.Color.White;
            this.lblRezervacijaID.Location = new System.Drawing.Point(14, 70);
            this.lblRezervacijaID.Name = "lblRezervacijaID";
            this.lblRezervacijaID.Size = new System.Drawing.Size(93, 17);
            this.lblRezervacijaID.TabIndex = 10;
            this.lblRezervacijaID.Text = "Rezervacija ID";
            // 
            // txtValueProjekcija
            // 
            this.txtValueProjekcija.Location = new System.Drawing.Point(191, 41);
            this.txtValueProjekcija.Name = "txtValueProjekcija";
            this.txtValueProjekcija.ReadOnly = true;
            this.txtValueProjekcija.Size = new System.Drawing.Size(117, 20);
            this.txtValueProjekcija.TabIndex = 9;
            // 
            // btnFindProjekcija
            // 
            this.btnFindProjekcija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFindProjekcija.Enabled = false;
            this.btnFindProjekcija.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindProjekcija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindProjekcija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindProjekcija.ForeColor = System.Drawing.Color.White;
            this.btnFindProjekcija.Location = new System.Drawing.Point(150, 40);
            this.btnFindProjekcija.Name = "btnFindProjekcija";
            this.btnFindProjekcija.Size = new System.Drawing.Size(38, 21);
            this.btnFindProjekcija.TabIndex = 8;
            this.btnFindProjekcija.Text = "...";
            this.btnFindProjekcija.UseVisualStyleBackColor = false;
            // 
            // txtKeyProjekcija
            // 
            this.txtKeyProjekcija.Location = new System.Drawing.Point(106, 40);
            this.txtKeyProjekcija.Name = "txtKeyProjekcija";
            this.txtKeyProjekcija.ReadOnly = true;
            this.txtKeyProjekcija.Size = new System.Drawing.Size(40, 20);
            this.txtKeyProjekcija.TabIndex = 7;
            // 
            // lblProjekcija
            // 
            this.lblProjekcija.AutoSize = true;
            this.lblProjekcija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjekcija.ForeColor = System.Drawing.Color.White;
            this.lblProjekcija.Location = new System.Drawing.Point(14, 43);
            this.lblProjekcija.Name = "lblProjekcija";
            this.lblProjekcija.Size = new System.Drawing.Size(81, 17);
            this.lblProjekcija.TabIndex = 6;
            this.lblProjekcija.Text = "Projekcija ID";
            // 
            // txtValueTermin
            // 
            this.txtValueTermin.Location = new System.Drawing.Point(191, 13);
            this.txtValueTermin.Name = "txtValueTermin";
            this.txtValueTermin.ReadOnly = true;
            this.txtValueTermin.Size = new System.Drawing.Size(117, 20);
            this.txtValueTermin.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnFind.Enabled = false;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(150, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(38, 21);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtKeyTermin
            // 
            this.txtKeyTermin.Location = new System.Drawing.Point(106, 12);
            this.txtKeyTermin.Name = "txtKeyTermin";
            this.txtKeyTermin.ReadOnly = true;
            this.txtKeyTermin.Size = new System.Drawing.Size(40, 20);
            this.txtKeyTermin.TabIndex = 3;
            // 
            // lblTerminID
            // 
            this.lblTerminID.AutoSize = true;
            this.lblTerminID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminID.ForeColor = System.Drawing.Color.White;
            this.lblTerminID.Location = new System.Drawing.Point(14, 15);
            this.lblTerminID.Name = "lblTerminID";
            this.lblTerminID.Size = new System.Drawing.Size(61, 17);
            this.lblTerminID.TabIndex = 2;
            this.lblTerminID.Text = "Termin ID";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(668, 47);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(162, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(668, 18);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(162, 23);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // panelNazivRezervacije
            // 
            this.panelNazivRezervacije.Controls.Add(this.panelRacun);
            this.panelNazivRezervacije.Controls.Add(this.lblNazivRezervacije);
            this.panelNazivRezervacije.Controls.Add(this.lblRezervacija);
            this.panelNazivRezervacije.Location = new System.Drawing.Point(675, 56);
            this.panelNazivRezervacije.Name = "panelNazivRezervacije";
            this.panelNazivRezervacije.Size = new System.Drawing.Size(178, 66);
            this.panelNazivRezervacije.TabIndex = 9;
            this.panelNazivRezervacije.Visible = false;
            // 
            // panelRacun
            // 
            this.panelRacun.Controls.Add(this.txtZaposleni);
            this.panelRacun.Controls.Add(this.lblZaposleni);
            this.panelRacun.Controls.Add(this.txtUkupnaVrijednost);
            this.panelRacun.Controls.Add(this.lblVrijednostRacuna);
            this.panelRacun.Location = new System.Drawing.Point(3, 3);
            this.panelRacun.Name = "panelRacun";
            this.panelRacun.Size = new System.Drawing.Size(171, 117);
            this.panelRacun.TabIndex = 11;
            this.panelRacun.Visible = false;
            // 
            // txtZaposleni
            // 
            this.txtZaposleni.Location = new System.Drawing.Point(29, 76);
            this.txtZaposleni.Name = "txtZaposleni";
            this.txtZaposleni.ReadOnly = true;
            this.txtZaposleni.Size = new System.Drawing.Size(127, 20);
            this.txtZaposleni.TabIndex = 3;
            this.txtZaposleni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposleni.ForeColor = System.Drawing.Color.White;
            this.lblZaposleni.Location = new System.Drawing.Point(61, 54);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(64, 17);
            this.lblZaposleni.TabIndex = 2;
            this.lblZaposleni.Text = "Zaposleni";
            // 
            // txtUkupnaVrijednost
            // 
            this.txtUkupnaVrijednost.Location = new System.Drawing.Point(38, 30);
            this.txtUkupnaVrijednost.Name = "txtUkupnaVrijednost";
            this.txtUkupnaVrijednost.ReadOnly = true;
            this.txtUkupnaVrijednost.Size = new System.Drawing.Size(109, 20);
            this.txtUkupnaVrijednost.TabIndex = 1;
            this.txtUkupnaVrijednost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVrijednostRacuna
            // 
            this.lblVrijednostRacuna.AutoSize = true;
            this.lblVrijednostRacuna.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijednostRacuna.ForeColor = System.Drawing.Color.White;
            this.lblVrijednostRacuna.Location = new System.Drawing.Point(44, 8);
            this.lblVrijednostRacuna.Name = "lblVrijednostRacuna";
            this.lblVrijednostRacuna.Size = new System.Drawing.Size(95, 17);
            this.lblVrijednostRacuna.TabIndex = 0;
            this.lblVrijednostRacuna.Text = "Ukupna cijena ";
            // 
            // lblNazivRezervacije
            // 
            this.lblNazivRezervacije.AutoSize = true;
            this.lblNazivRezervacije.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivRezervacije.ForeColor = System.Drawing.Color.White;
            this.lblNazivRezervacije.Location = new System.Drawing.Point(82, 9);
            this.lblNazivRezervacije.Name = "lblNazivRezervacije";
            this.lblNazivRezervacije.Size = new System.Drawing.Size(45, 17);
            this.lblNazivRezervacije.TabIndex = 10;
            this.lblNazivRezervacije.Text = "label1";
            // 
            // lblRezervacija
            // 
            this.lblRezervacija.AutoSize = true;
            this.lblRezervacija.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezervacija.ForeColor = System.Drawing.Color.White;
            this.lblRezervacija.Location = new System.Drawing.Point(10, 9);
            this.lblRezervacija.Name = "lblRezervacija";
            this.lblRezervacija.Size = new System.Drawing.Size(81, 17);
            this.lblRezervacija.TabIndex = 10;
            this.lblRezervacija.Text = "Rezervacija:";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Cinema.Properties.Resources.x_mark;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(830, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 20);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelOkvir
            // 
            this.panelOkvir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOkvir.Controls.Add(this.panelKarta);
            this.panelOkvir.Controls.Add(this.lblTermin);
            this.panelOkvir.Controls.Add(this.lblNazivFilma);
            this.panelOkvir.Controls.Add(this.panelButton);
            this.panelOkvir.Controls.Add(this.panelPretraga);
            this.panelOkvir.Controls.Add(this.tabControlRezervacija);
            this.panelOkvir.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelOkvir.Location = new System.Drawing.Point(0, 0);
            this.panelOkvir.Name = "panelOkvir";
            this.panelOkvir.Size = new System.Drawing.Size(852, 396);
            this.panelOkvir.TabIndex = 11;
            // 
            // RezervacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(854, 397);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelNazivRezervacije);
            this.Controls.Add(this.panelOkvir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervacijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervacijaForm";
            this.tabControlRezervacija.ResumeLayout(false);
            this.tabPageRezervacija.ResumeLayout(false);
            this.tabPageRezervacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledRezervacija)).EndInit();
            this.tabPageRezervacijaDetaljno.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljnoRezervacija)).EndInit();
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelKarta.ResumeLayout(false);
            this.panelKarta.PerformLayout();
            this.panelNazivRezervacije.ResumeLayout(false);
            this.panelNazivRezervacije.PerformLayout();
            this.panelRacun.ResumeLayout(false);
            this.panelRacun.PerformLayout();
            this.panelOkvir.ResumeLayout(false);
            this.panelOkvir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRezervacija;
        private System.Windows.Forms.TabPage tabPageRezervacija;
        private System.Windows.Forms.TabPage tabPageRezervacijaDetaljno;
        private System.Windows.Forms.DataGridView dgvPregledRezervacija;
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
        private System.Windows.Forms.Panel panelRacun;
        private System.Windows.Forms.TextBox txtZaposleni;
        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.TextBox txtUkupnaVrijednost;
        private System.Windows.Forms.Label lblVrijednostRacuna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tsbtnObrisi;
        private System.Windows.Forms.Button tsbtnIzmijeni;
        private System.Windows.Forms.Button tsbtnDodaj;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelOkvir;
    }
}