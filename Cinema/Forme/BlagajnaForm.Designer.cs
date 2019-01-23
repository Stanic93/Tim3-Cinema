namespace Cinema.Forme
{
    partial class BlagajnaForm
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
            this.components = new System.ComponentModel.Container();
            this.gbKarta = new System.Windows.Forms.GroupBox();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.btnNovaKarta = new System.Windows.Forms.Button();
            this.dtpDatumProdukcije = new System.Windows.Forms.DateTimePicker();
            this.lblDatumProdukcije = new System.Windows.Forms.Label();
            this.gbPregled = new System.Windows.Forms.GroupBox();
            this.panelToolStrip = new System.Windows.Forms.Panel();
            this.tsbtnObrisi = new System.Windows.Forms.Button();
            this.tsbtnIzmijeni = new System.Windows.Forms.Button();
            this.tsbtnDodaj = new System.Windows.Forms.Button();
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.btnVratiNaKartu = new System.Windows.Forms.Button();
            this.panelPretraga = new System.Windows.Forms.Panel();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.lblZanrFilma = new System.Windows.Forms.Label();
            this.gbDetaljno = new System.Windows.Forms.GroupBox();
            this.btnOdustaniRacun = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.flpDetaljno = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRacun = new System.Windows.Forms.Panel();
            this.txtZaposleni = new System.Windows.Forms.TextBox();
            this.lblZaposleni = new System.Windows.Forms.Label();
            this.txtUkupnaVrijednost = new System.Windows.Forms.TextBox();
            this.lblVrijednostRacuna = new System.Windows.Forms.Label();
            this.lblStatusSale = new System.Windows.Forms.Label();
            this.lblStanjeSale = new System.Windows.Forms.Label();
            this.panelPregledRacuna = new System.Windows.Forms.Panel();
            this.btnTabRepertoar = new System.Windows.Forms.Button();
            this.btnTabKarta = new System.Windows.Forms.Button();
            this.btnTabRacun = new System.Windows.Forms.Button();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblRadnik = new System.Windows.Forms.Label();
            this.btnTabRezervacija = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbRacun = new System.Windows.Forms.PictureBox();
            this.pbKarta = new System.Windows.Forms.PictureBox();
            this.pbRezervacija = new System.Windows.Forms.PictureBox();
            this.pbRepertoar = new System.Windows.Forms.PictureBox();
            this.pBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblSatKrug = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lblSat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gbKarta.SuspendLayout();
            this.gbPregled.SuspendLayout();
            this.panelToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.panelPretraga.SuspendLayout();
            this.gbDetaljno.SuspendLayout();
            this.panelRacun.SuspendLayout();
            this.panelPregledRacuna.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRezervacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepertoar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKarta
            // 
            this.gbKarta.Controls.Add(this.btnRezervacija);
            this.gbKarta.Controls.Add(this.btnNovaKarta);
            this.gbKarta.Controls.Add(this.dtpDatumProdukcije);
            this.gbKarta.Controls.Add(this.lblDatumProdukcije);
            this.gbKarta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKarta.ForeColor = System.Drawing.Color.White;
            this.gbKarta.Location = new System.Drawing.Point(280, 297);
            this.gbKarta.Name = "gbKarta";
            this.gbKarta.Size = new System.Drawing.Size(297, 85);
            this.gbKarta.TabIndex = 7;
            this.gbKarta.TabStop = false;
            this.gbKarta.Text = "Karta";
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervacija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRezervacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervacija.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervacija.Location = new System.Drawing.Point(6, 41);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(139, 38);
            this.btnRezervacija.TabIndex = 13;
            this.btnRezervacija.Text = "Rezervacija";
            this.btnRezervacija.UseVisualStyleBackColor = false;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // btnNovaKarta
            // 
            this.btnNovaKarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnNovaKarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaKarta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNovaKarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaKarta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaKarta.Location = new System.Drawing.Point(151, 41);
            this.btnNovaKarta.Name = "btnNovaKarta";
            this.btnNovaKarta.Size = new System.Drawing.Size(139, 38);
            this.btnNovaKarta.TabIndex = 12;
            this.btnNovaKarta.Text = "Karta";
            this.btnNovaKarta.UseVisualStyleBackColor = false;
            this.btnNovaKarta.Click += new System.EventHandler(this.btnNovaKarta_Click);
            // 
            // dtpDatumProdukcije
            // 
            this.dtpDatumProdukcije.CustomFormat = "dd-MM-yyyy";
            this.dtpDatumProdukcije.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumProdukcije.Location = new System.Drawing.Point(141, 15);
            this.dtpDatumProdukcije.MaxDate = new System.DateTime(2018, 12, 21, 0, 0, 0, 0);
            this.dtpDatumProdukcije.MinDate = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.dtpDatumProdukcije.Name = "dtpDatumProdukcije";
            this.dtpDatumProdukcije.Size = new System.Drawing.Size(149, 22);
            this.dtpDatumProdukcije.TabIndex = 10;
            this.dtpDatumProdukcije.Value = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.dtpDatumProdukcije.ValueChanged += new System.EventHandler(this.dtpDatumProdukcije_ValueChanged);
            // 
            // lblDatumProdukcije
            // 
            this.lblDatumProdukcije.AutoSize = true;
            this.lblDatumProdukcije.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumProdukcije.Location = new System.Drawing.Point(25, 18);
            this.lblDatumProdukcije.Name = "lblDatumProdukcije";
            this.lblDatumProdukcije.Size = new System.Drawing.Size(110, 17);
            this.lblDatumProdukcije.TabIndex = 8;
            this.lblDatumProdukcije.Text = "Datum projekcije";
            // 
            // gbPregled
            // 
            this.gbPregled.Controls.Add(this.panelToolStrip);
            this.gbPregled.Controls.Add(this.dgvPregled);
            this.gbPregled.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPregled.ForeColor = System.Drawing.Color.White;
            this.gbPregled.Location = new System.Drawing.Point(554, 217);
            this.gbPregled.Name = "gbPregled";
            this.gbPregled.Size = new System.Drawing.Size(580, 302);
            this.gbPregled.TabIndex = 6;
            this.gbPregled.TabStop = false;
            this.gbPregled.Text = "Pregled";
            // 
            // panelToolStrip
            // 
            this.panelToolStrip.Controls.Add(this.tsbtnObrisi);
            this.panelToolStrip.Controls.Add(this.tsbtnIzmijeni);
            this.panelToolStrip.Controls.Add(this.tsbtnDodaj);
            this.panelToolStrip.Location = new System.Drawing.Point(3, 18);
            this.panelToolStrip.Name = "panelToolStrip";
            this.panelToolStrip.Size = new System.Drawing.Size(537, 30);
            this.panelToolStrip.TabIndex = 1;
            // 
            // tsbtnObrisi
            // 
            this.tsbtnObrisi.BackgroundImage = global::Cinema.Properties.Resources.delete;
            this.tsbtnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnObrisi.FlatAppearance.BorderSize = 0;
            this.tsbtnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnObrisi.Location = new System.Drawing.Point(104, 3);
            this.tsbtnObrisi.Name = "tsbtnObrisi";
            this.tsbtnObrisi.Size = new System.Drawing.Size(38, 23);
            this.tsbtnObrisi.TabIndex = 2;
            this.tsbtnObrisi.UseVisualStyleBackColor = true;
            this.tsbtnObrisi.Click += new System.EventHandler(this.tsbtnObrisi_Click);
            // 
            // tsbtnIzmijeni
            // 
            this.tsbtnIzmijeni.BackgroundImage = global::Cinema.Properties.Resources.pencil_edit_button;
            this.tsbtnIzmijeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
            this.tsbtnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnIzmijeni.Location = new System.Drawing.Point(56, 3);
            this.tsbtnIzmijeni.Name = "tsbtnIzmijeni";
            this.tsbtnIzmijeni.Size = new System.Drawing.Size(38, 23);
            this.tsbtnIzmijeni.TabIndex = 1;
            this.tsbtnIzmijeni.UseVisualStyleBackColor = true;
            this.tsbtnIzmijeni.Click += new System.EventHandler(this.tsbtnIzmijeni_Click);
            // 
            // tsbtnDodaj
            // 
            this.tsbtnDodaj.BackgroundImage = global::Cinema.Properties.Resources.add;
            this.tsbtnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnDodaj.FlatAppearance.BorderSize = 0;
            this.tsbtnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnDodaj.Location = new System.Drawing.Point(6, 3);
            this.tsbtnDodaj.Name = "tsbtnDodaj";
            this.tsbtnDodaj.Size = new System.Drawing.Size(38, 23);
            this.tsbtnDodaj.TabIndex = 0;
            this.tsbtnDodaj.UseVisualStyleBackColor = true;
            this.tsbtnDodaj.Click += new System.EventHandler(this.tsbtnDodaj_Click);
            // 
            // dgvPregled
            // 
            this.dgvPregled.AllowUserToAddRows = false;
            this.dgvPregled.AllowUserToDeleteRows = false;
            this.dgvPregled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregled.BackgroundColor = System.Drawing.Color.White;
            this.dgvPregled.ColumnHeadersHeight = 25;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPregled.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPregled.Location = new System.Drawing.Point(3, 48);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.ReadOnly = true;
            this.dgvPregled.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPregled.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPregled.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPregled.RowTemplate.DefaultCellStyle.NullValue = "/";
            this.dgvPregled.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPregled.Size = new System.Drawing.Size(574, 251);
            this.dgvPregled.TabIndex = 0;
            this.dgvPregled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregled_CellClick);
            this.dgvPregled.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPregled_CellFormatting);
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnDodajRezervaciju);
            this.gbPretraga.Controls.Add(this.btnVratiNaKartu);
            this.gbPretraga.Controls.Add(this.panelPretraga);
            this.gbPretraga.Controls.Add(this.lblNazivFilma);
            this.gbPretraga.Controls.Add(this.lblZanrFilma);
            this.gbPretraga.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPretraga.ForeColor = System.Drawing.Color.White;
            this.gbPretraga.Location = new System.Drawing.Point(554, 112);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(580, 99);
            this.gbPretraga.TabIndex = 5;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDodajRezervaciju.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajRezervaciju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(355, 55);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(215, 38);
            this.btnDodajRezervaciju.TabIndex = 15;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Visible = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // btnVratiNaKartu
            // 
            this.btnVratiNaKartu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnVratiNaKartu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVratiNaKartu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVratiNaKartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVratiNaKartu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVratiNaKartu.Location = new System.Drawing.Point(355, 15);
            this.btnVratiNaKartu.Name = "btnVratiNaKartu";
            this.btnVratiNaKartu.Size = new System.Drawing.Size(215, 38);
            this.btnVratiNaKartu.TabIndex = 14;
            this.btnVratiNaKartu.Text = "Dodaj kartu";
            this.btnVratiNaKartu.UseVisualStyleBackColor = false;
            this.btnVratiNaKartu.Visible = false;
            this.btnVratiNaKartu.Click += new System.EventHandler(this.btnVratiNaKartu_Click);
            // 
            // panelPretraga
            // 
            this.panelPretraga.Controls.Add(this.btnPrikaziSve);
            this.panelPretraga.Controls.Add(this.lblNaziv);
            this.panelPretraga.Controls.Add(this.txtNaziv);
            this.panelPretraga.Location = new System.Drawing.Point(108, 12);
            this.panelPretraga.Name = "panelPretraga";
            this.panelPretraga.Size = new System.Drawing.Size(372, 74);
            this.panelPretraga.TabIndex = 10;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnPrikaziSve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrikaziSve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrikaziSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaziSve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziSve.Location = new System.Drawing.Point(227, 26);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(142, 27);
            this.btnPrikaziSve.TabIndex = 7;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = false;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(10, 30);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(49, 20);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(71, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(150, 26);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivFilma.Location = new System.Drawing.Point(16, 25);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(0, 20);
            this.lblNazivFilma.TabIndex = 8;
            // 
            // lblZanrFilma
            // 
            this.lblZanrFilma.AutoSize = true;
            this.lblZanrFilma.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZanrFilma.Location = new System.Drawing.Point(16, 45);
            this.lblZanrFilma.Name = "lblZanrFilma";
            this.lblZanrFilma.Size = new System.Drawing.Size(0, 20);
            this.lblZanrFilma.TabIndex = 9;
            // 
            // gbDetaljno
            // 
            this.gbDetaljno.Controls.Add(this.btnOdustaniRacun);
            this.gbDetaljno.Controls.Add(this.btnPotvrdi);
            this.gbDetaljno.Controls.Add(this.flpDetaljno);
            this.gbDetaljno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetaljno.ForeColor = System.Drawing.Color.White;
            this.gbDetaljno.Location = new System.Drawing.Point(256, 112);
            this.gbDetaljno.Name = "gbDetaljno";
            this.gbDetaljno.Size = new System.Drawing.Size(292, 533);
            this.gbDetaljno.TabIndex = 4;
            this.gbDetaljno.TabStop = false;
            this.gbDetaljno.Text = "Detaljno";
            // 
            // btnOdustaniRacun
            // 
            this.btnOdustaniRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnOdustaniRacun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustaniRacun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOdustaniRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustaniRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustaniRacun.Location = new System.Drawing.Point(7, 477);
            this.btnOdustaniRacun.Name = "btnOdustaniRacun";
            this.btnOdustaniRacun.Size = new System.Drawing.Size(121, 41);
            this.btnOdustaniRacun.TabIndex = 9;
            this.btnOdustaniRacun.Text = "Odustani";
            this.btnOdustaniRacun.UseVisualStyleBackColor = false;
            this.btnOdustaniRacun.Visible = false;
            this.btnOdustaniRacun.Click += new System.EventHandler(this.btnOdustaniRacun_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(164, 478);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(121, 41);
            this.btnPotvrdi.TabIndex = 8;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // flpDetaljno
            // 
            this.flpDetaljno.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDetaljno.Location = new System.Drawing.Point(7, 19);
            this.flpDetaljno.Margin = new System.Windows.Forms.Padding(0);
            this.flpDetaljno.Name = "flpDetaljno";
            this.flpDetaljno.Size = new System.Drawing.Size(282, 455);
            this.flpDetaljno.TabIndex = 0;
            // 
            // panelRacun
            // 
            this.panelRacun.Controls.Add(this.txtZaposleni);
            this.panelRacun.Controls.Add(this.lblZaposleni);
            this.panelRacun.Controls.Add(this.txtUkupnaVrijednost);
            this.panelRacun.Controls.Add(this.lblVrijednostRacuna);
            this.panelRacun.Location = new System.Drawing.Point(9, 299);
            this.panelRacun.Name = "panelRacun";
            this.panelRacun.Size = new System.Drawing.Size(261, 84);
            this.panelRacun.TabIndex = 8;
            this.panelRacun.Visible = false;
            // 
            // txtZaposleni
            // 
            this.txtZaposleni.Location = new System.Drawing.Point(113, 47);
            this.txtZaposleni.Name = "txtZaposleni";
            this.txtZaposleni.Size = new System.Drawing.Size(133, 20);
            this.txtZaposleni.TabIndex = 3;
            // 
            // lblZaposleni
            // 
            this.lblZaposleni.AutoSize = true;
            this.lblZaposleni.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaposleni.ForeColor = System.Drawing.Color.White;
            this.lblZaposleni.Location = new System.Drawing.Point(3, 49);
            this.lblZaposleni.Name = "lblZaposleni";
            this.lblZaposleni.Size = new System.Drawing.Size(59, 15);
            this.lblZaposleni.TabIndex = 2;
            this.lblZaposleni.Text = "Zaposleni";
            // 
            // txtUkupnaVrijednost
            // 
            this.txtUkupnaVrijednost.Location = new System.Drawing.Point(137, 9);
            this.txtUkupnaVrijednost.Name = "txtUkupnaVrijednost";
            this.txtUkupnaVrijednost.Size = new System.Drawing.Size(109, 20);
            this.txtUkupnaVrijednost.TabIndex = 1;
            // 
            // lblVrijednostRacuna
            // 
            this.lblVrijednostRacuna.AutoSize = true;
            this.lblVrijednostRacuna.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijednostRacuna.ForeColor = System.Drawing.Color.White;
            this.lblVrijednostRacuna.Location = new System.Drawing.Point(3, 11);
            this.lblVrijednostRacuna.Name = "lblVrijednostRacuna";
            this.lblVrijednostRacuna.Size = new System.Drawing.Size(88, 15);
            this.lblVrijednostRacuna.TabIndex = 0;
            this.lblVrijednostRacuna.Text = "Ukupna cijena ";
            // 
            // lblStatusSale
            // 
            this.lblStatusSale.AutoSize = true;
            this.lblStatusSale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusSale.ForeColor = System.Drawing.Color.White;
            this.lblStatusSale.Location = new System.Drawing.Point(314, 78);
            this.lblStatusSale.Name = "lblStatusSale";
            this.lblStatusSale.Size = new System.Drawing.Size(84, 20);
            this.lblStatusSale.TabIndex = 10;
            this.lblStatusSale.Text = "Status sale";
            this.lblStatusSale.Visible = false;
            // 
            // lblStanjeSale
            // 
            this.lblStanjeSale.AutoSize = true;
            this.lblStanjeSale.Location = new System.Drawing.Point(691, 134);
            this.lblStanjeSale.Name = "lblStanjeSale";
            this.lblStanjeSale.Size = new System.Drawing.Size(0, 13);
            this.lblStanjeSale.TabIndex = 11;
            this.lblStanjeSale.Visible = false;
            // 
            // panelPregledRacuna
            // 
            this.panelPregledRacuna.Controls.Add(this.gbKarta);
            this.panelPregledRacuna.Controls.Add(this.panelRacun);
            this.panelPregledRacuna.Location = new System.Drawing.Point(554, 248);
            this.panelPregledRacuna.Name = "panelPregledRacuna";
            this.panelPregledRacuna.Size = new System.Drawing.Size(577, 397);
            this.panelPregledRacuna.TabIndex = 12;
            // 
            // btnTabRepertoar
            // 
            this.btnTabRepertoar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabRepertoar.FlatAppearance.BorderSize = 0;
            this.btnTabRepertoar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabRepertoar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabRepertoar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRepertoar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabRepertoar.ForeColor = System.Drawing.Color.White;
            this.btnTabRepertoar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabRepertoar.Location = new System.Drawing.Point(3, 204);
            this.btnTabRepertoar.Name = "btnTabRepertoar";
            this.btnTabRepertoar.Size = new System.Drawing.Size(244, 50);
            this.btnTabRepertoar.TabIndex = 2;
            this.btnTabRepertoar.Text = "             REPERTOAR";
            this.btnTabRepertoar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabRepertoar.UseVisualStyleBackColor = true;
            // 
            // btnTabKarta
            // 
            this.btnTabKarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabKarta.FlatAppearance.BorderSize = 0;
            this.btnTabKarta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabKarta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabKarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabKarta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabKarta.ForeColor = System.Drawing.Color.White;
            this.btnTabKarta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabKarta.Location = new System.Drawing.Point(3, 322);
            this.btnTabKarta.Name = "btnTabKarta";
            this.btnTabKarta.Size = new System.Drawing.Size(244, 50);
            this.btnTabKarta.TabIndex = 3;
            this.btnTabKarta.Text = "    KARTA";
            this.btnTabKarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabKarta.UseVisualStyleBackColor = true;
            // 
            // btnTabRacun
            // 
            this.btnTabRacun.Cursor = System.Windows.Forms.Cursors.No;
            this.btnTabRacun.FlatAppearance.BorderSize = 0;
            this.btnTabRacun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabRacun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRacun.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabRacun.ForeColor = System.Drawing.Color.White;
            this.btnTabRacun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabRacun.Location = new System.Drawing.Point(3, 382);
            this.btnTabRacun.Name = "btnTabRacun";
            this.btnTabRacun.Size = new System.Drawing.Size(244, 50);
            this.btnTabRacun.TabIndex = 4;
            this.btnTabRacun.Text = "      RACUN";
            this.btnTabRacun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabRacun.UseVisualStyleBackColor = true;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(73, 112);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(100, 17);
            this.lblKorisnickoIme.TabIndex = 5;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRadnik.Location = new System.Drawing.Point(73, 134);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(66, 17);
            this.lblRadnik.TabIndex = 6;
            this.lblRadnik.Text = "Blagajnik";
            // 
            // btnTabRezervacija
            // 
            this.btnTabRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabRezervacija.FlatAppearance.BorderSize = 0;
            this.btnTabRezervacija.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabRezervacija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnTabRezervacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRezervacija.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabRezervacija.ForeColor = System.Drawing.Color.White;
            this.btnTabRezervacija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabRezervacija.Location = new System.Drawing.Point(3, 261);
            this.btnTabRezervacija.Name = "btnTabRezervacija";
            this.btnTabRezervacija.Size = new System.Drawing.Size(244, 50);
            this.btnTabRezervacija.TabIndex = 8;
            this.btnTabRezervacija.Text = "                 REZERVACIJA";
            this.btnTabRezervacija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabRezervacija.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pbRacun);
            this.panel1.Controls.Add(this.pbKarta);
            this.panel1.Controls.Add(this.pbRezervacija);
            this.panel1.Controls.Add(this.pbRepertoar);
            this.panel1.Controls.Add(this.btnTabRezervacija);
            this.panel1.Controls.Add(this.lblRadnik);
            this.panel1.Controls.Add(this.lblKorisnickoIme);
            this.panel1.Controls.Add(this.pBoxAvatar);
            this.panel1.Controls.Add(this.btnTabRacun);
            this.panel1.Controls.Add(this.btnTabKarta);
            this.panel1.Controls.Add(this.btnTabRepertoar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 651);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::Cinema.Properties.Resources.log_out;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 615);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(39, 36);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbRacun
            // 
            this.pbRacun.Image = global::Cinema.Properties.Resources.banknote;
            this.pbRacun.Location = new System.Drawing.Point(38, 386);
            this.pbRacun.Name = "pbRacun";
            this.pbRacun.Size = new System.Drawing.Size(51, 41);
            this.pbRacun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRacun.TabIndex = 12;
            this.pbRacun.TabStop = false;
            // 
            // pbKarta
            // 
            this.pbKarta.Image = global::Cinema.Properties.Resources.two_tickets;
            this.pbKarta.Location = new System.Drawing.Point(38, 326);
            this.pbKarta.Name = "pbKarta";
            this.pbKarta.Size = new System.Drawing.Size(51, 41);
            this.pbKarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKarta.TabIndex = 11;
            this.pbKarta.TabStop = false;
            // 
            // pbRezervacija
            // 
            this.pbRezervacija.Image = global::Cinema.Properties.Resources.reserved;
            this.pbRezervacija.Location = new System.Drawing.Point(38, 265);
            this.pbRezervacija.Name = "pbRezervacija";
            this.pbRezervacija.Size = new System.Drawing.Size(51, 41);
            this.pbRezervacija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRezervacija.TabIndex = 10;
            this.pbRezervacija.TabStop = false;
            // 
            // pbRepertoar
            // 
            this.pbRepertoar.Image = global::Cinema.Properties.Resources.movie_clapper_open;
            this.pbRepertoar.Location = new System.Drawing.Point(38, 208);
            this.pbRepertoar.Name = "pbRepertoar";
            this.pbRepertoar.Size = new System.Drawing.Size(51, 41);
            this.pbRepertoar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRepertoar.TabIndex = 9;
            this.pbRepertoar.TabStop = false;
            // 
            // pBoxAvatar
            // 
            this.pBoxAvatar.Image = global::Cinema.Properties.Resources.man_user;
            this.pBoxAvatar.Location = new System.Drawing.Point(75, 12);
            this.pBoxAvatar.Name = "pBoxAvatar";
            this.pBoxAvatar.Size = new System.Drawing.Size(107, 86);
            this.pBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxAvatar.TabIndex = 4;
            this.pBoxAvatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.lblDatum);
            this.panel2.Controls.Add(this.lblSatKrug);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.lblSat);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblStatusSale);
            this.panel2.Location = new System.Drawing.Point(236, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 106);
            this.panel2.TabIndex = 13;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDatum.Location = new System.Drawing.Point(811, 64);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(45, 17);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "label3";
            // 
            // lblSatKrug
            // 
            this.lblSatKrug.AutoSize = true;
            this.lblSatKrug.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatKrug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSatKrug.Location = new System.Drawing.Point(804, 32);
            this.lblSatKrug.Name = "lblSatKrug";
            this.lblSatKrug.Size = new System.Drawing.Size(98, 33);
            this.lblSatKrug.TabIndex = 15;
            this.lblSatKrug.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(827, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(786, 0);
            this.circularProgressBar1.MarqueeAnimationSpeed = 10000;
            this.circularProgressBar1.Maximum = 60;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 2;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(112, 99);
            this.circularProgressBar1.StartAngle = -90;
            this.circularProgressBar1.Step = 1000;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 13;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 60;
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSat.Location = new System.Drawing.Point(795, 70);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(0, 28);
            this.lblSat.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.logo_cine_23_2147503279__1_;
            this.pictureBox1.Location = new System.Drawing.Point(20, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BlagajnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1136, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbPregled);
            this.Controls.Add(this.lblStanjeSale);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbDetaljno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPregledRacuna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlagajnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlagajnaForm";
            this.gbKarta.ResumeLayout(false);
            this.gbKarta.PerformLayout();
            this.gbPregled.ResumeLayout(false);
            this.panelToolStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.panelPretraga.ResumeLayout(false);
            this.panelPretraga.PerformLayout();
            this.gbDetaljno.ResumeLayout(false);
            this.panelRacun.ResumeLayout(false);
            this.panelRacun.PerformLayout();
            this.panelPregledRacuna.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRezervacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRepertoar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbKarta;
        private System.Windows.Forms.Button btnNovaKarta;
        private System.Windows.Forms.DateTimePicker dtpDatumProdukcije;
        private System.Windows.Forms.Label lblDatumProdukcije;
        private System.Windows.Forms.GroupBox gbPregled;
        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.GroupBox gbDetaljno;
        private System.Windows.Forms.FlowLayoutPanel flpDetaljno;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Panel panelRacun;
        private System.Windows.Forms.TextBox txtUkupnaVrijednost;
        private System.Windows.Forms.Label lblVrijednostRacuna;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.Label lblZanrFilma;
        private System.Windows.Forms.Label lblStatusSale;
        private System.Windows.Forms.Label lblStanjeSale;
        private System.Windows.Forms.Panel panelPretraga;
        private System.Windows.Forms.Panel panelPregledRacuna;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.TextBox txtZaposleni;
        private System.Windows.Forms.Label lblZaposleni;
        private System.Windows.Forms.Button btnOdustaniRacun;
        private System.Windows.Forms.Button btnVratiNaKartu;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button btnTabRepertoar;
        private System.Windows.Forms.Button btnTabKarta;
        private System.Windows.Forms.Button btnTabRacun;
        private System.Windows.Forms.PictureBox pBoxAvatar;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.Button btnTabRezervacija;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbRacun;
        private System.Windows.Forms.PictureBox pbKarta;
        private System.Windows.Forms.PictureBox pbRezervacija;
        private System.Windows.Forms.PictureBox pbRepertoar;
        private System.Windows.Forms.Panel panelToolStrip;
        private System.Windows.Forms.Button tsbtnObrisi;
        private System.Windows.Forms.Button tsbtnIzmijeni;
        private System.Windows.Forms.Button tsbtnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogout;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSatKrug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}