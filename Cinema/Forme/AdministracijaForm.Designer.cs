namespace Cinema.Forme
{
    partial class AdministracijaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracijaForm));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblAdministracija = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelCrvenaLinija = new System.Windows.Forms.Panel();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.panelTerminiSelected = new System.Windows.Forms.Panel();
            this.btnTermini = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pBoxAvatar = new System.Windows.Forms.PictureBox();
            this.panelFilmSelected = new System.Windows.Forms.Panel();
            this.btnFilm = new System.Windows.Forms.Button();
            this.panelLoginSelected = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelZanrSelected = new System.Windows.Forms.Panel();
            this.panelProjekcijaSelected = new System.Windows.Forms.Panel();
            this.panelZaposleniSelected = new System.Windows.Forms.Panel();
            this.btnZanr = new System.Windows.Forms.Button();
            this.btnProjekcija = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.gbDetaljno = new System.Windows.Forms.GroupBox();
            this.toolStripKarta = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIzmjein = new System.Windows.Forms.ToolStripButton();
            this.tsbtnObrisi = new System.Windows.Forms.ToolStripButton();
            this.flpDetaljno = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.panelMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).BeginInit();
            this.gbPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.gbDetaljno.SuspendLayout();
            this.toolStripKarta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Red;
            this.panelLogo.Controls.Add(this.lblAdministracija);
            this.panelLogo.Controls.Add(this.lblCinema);
            this.panelLogo.Controls.Add(this.pBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(265, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(112, 134);
            this.panelLogo.TabIndex = 4;
            // 
            // lblAdministracija
            // 
            this.lblAdministracija.AutoSize = true;
            this.lblAdministracija.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracija.ForeColor = System.Drawing.Color.White;
            this.lblAdministracija.Location = new System.Drawing.Point(1, 107);
            this.lblAdministracija.Name = "lblAdministracija";
            this.lblAdministracija.Size = new System.Drawing.Size(110, 20);
            this.lblAdministracija.TabIndex = 3;
            this.lblAdministracija.Text = "Administracija";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.White;
            this.lblCinema.Location = new System.Drawing.Point(19, 87);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(72, 19);
            this.lblCinema.TabIndex = 2;
            this.lblCinema.Text = "Cinema";
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLogo.Image")));
            this.pBoxLogo.Location = new System.Drawing.Point(6, 11);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(99, 71);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 2;
            this.pBoxLogo.TabStop = false;
            // 
            // panelCrvenaLinija
            // 
            this.panelCrvenaLinija.BackColor = System.Drawing.Color.Red;
            this.panelCrvenaLinija.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCrvenaLinija.Location = new System.Drawing.Point(260, 0);
            this.panelCrvenaLinija.Name = "panelCrvenaLinija";
            this.panelCrvenaLinija.Size = new System.Drawing.Size(892, 6);
            this.panelCrvenaLinija.TabIndex = 2;
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMeni.Controls.Add(this.panelTerminiSelected);
            this.panelMeni.Controls.Add(this.btnTermini);
            this.panelMeni.Controls.Add(this.lblAdmin);
            this.panelMeni.Controls.Add(this.lblKorisnickoIme);
            this.panelMeni.Controls.Add(this.pBoxAvatar);
            this.panelMeni.Controls.Add(this.panelFilmSelected);
            this.panelMeni.Controls.Add(this.btnFilm);
            this.panelMeni.Controls.Add(this.panelLoginSelected);
            this.panelMeni.Controls.Add(this.btnLogin);
            this.panelMeni.Controls.Add(this.panelZanrSelected);
            this.panelMeni.Controls.Add(this.panelProjekcijaSelected);
            this.panelMeni.Controls.Add(this.panelZaposleniSelected);
            this.panelMeni.Controls.Add(this.btnZanr);
            this.panelMeni.Controls.Add(this.btnProjekcija);
            this.panelMeni.Controls.Add(this.btnZaposleni);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(260, 700);
            this.panelMeni.TabIndex = 3;
            // 
            // panelTerminiSelected
            // 
            this.panelTerminiSelected.BackColor = System.Drawing.Color.Red;
            this.panelTerminiSelected.Enabled = false;
            this.panelTerminiSelected.ForeColor = System.Drawing.Color.White;
            this.panelTerminiSelected.Location = new System.Drawing.Point(3, 316);
            this.panelTerminiSelected.Name = "panelTerminiSelected";
            this.panelTerminiSelected.Size = new System.Drawing.Size(6, 50);
            this.panelTerminiSelected.TabIndex = 10;
            this.panelTerminiSelected.Visible = false;
            // 
            // btnTermini
            // 
            this.btnTermini.FlatAppearance.BorderSize = 0;
            this.btnTermini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermini.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermini.ForeColor = System.Drawing.Color.White;
            this.btnTermini.Image = ((System.Drawing.Image)(resources.GetObject("btnTermini.Image")));
            this.btnTermini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTermini.Location = new System.Drawing.Point(12, 318);
            this.btnTermini.Name = "btnTermini";
            this.btnTermini.Size = new System.Drawing.Size(261, 50);
            this.btnTermini.TabIndex = 11;
            this.btnTermini.Text = "               TERMINI";
            this.btnTermini.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTermini.UseVisualStyleBackColor = true;
            this.btnTermini.Click += new System.EventHandler(this.Btn_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(91, 134);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "Admin";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(91, 112);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 11;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // pBoxAvatar
            // 
            this.pBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pBoxAvatar.Image")));
            this.pBoxAvatar.Location = new System.Drawing.Point(64, 12);
            this.pBoxAvatar.Name = "pBoxAvatar";
            this.pBoxAvatar.Size = new System.Drawing.Size(107, 86);
            this.pBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxAvatar.TabIndex = 10;
            this.pBoxAvatar.TabStop = false;
            // 
            // panelFilmSelected
            // 
            this.panelFilmSelected.BackColor = System.Drawing.Color.Red;
            this.panelFilmSelected.Enabled = false;
            this.panelFilmSelected.ForeColor = System.Drawing.Color.White;
            this.panelFilmSelected.Location = new System.Drawing.Point(3, 260);
            this.panelFilmSelected.Name = "panelFilmSelected";
            this.panelFilmSelected.Size = new System.Drawing.Size(6, 50);
            this.panelFilmSelected.TabIndex = 8;
            this.panelFilmSelected.Visible = false;
            // 
            // btnFilm
            // 
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnFilm.Image")));
            this.btnFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm.Location = new System.Drawing.Point(12, 262);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(261, 50);
            this.btnFilm.TabIndex = 9;
            this.btnFilm.Text = "                FILM";
            this.btnFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilm.UseVisualStyleBackColor = true;
            // 
            // panelLoginSelected
            // 
            this.panelLoginSelected.BackColor = System.Drawing.Color.Red;
            this.panelLoginSelected.Enabled = false;
            this.panelLoginSelected.ForeColor = System.Drawing.Color.White;
            this.panelLoginSelected.Location = new System.Drawing.Point(3, 486);
            this.panelLoginSelected.Name = "panelLoginSelected";
            this.panelLoginSelected.Size = new System.Drawing.Size(6, 50);
            this.panelLoginSelected.TabIndex = 6;
            this.panelLoginSelected.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(12, 488);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(261, 50);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "               LOGIN";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // panelZanrSelected
            // 
            this.panelZanrSelected.BackColor = System.Drawing.Color.Red;
            this.panelZanrSelected.Enabled = false;
            this.panelZanrSelected.ForeColor = System.Drawing.Color.White;
            this.panelZanrSelected.Location = new System.Drawing.Point(3, 430);
            this.panelZanrSelected.Name = "panelZanrSelected";
            this.panelZanrSelected.Size = new System.Drawing.Size(6, 50);
            this.panelZanrSelected.TabIndex = 4;
            this.panelZanrSelected.Visible = false;
            // 
            // panelProjekcijaSelected
            // 
            this.panelProjekcijaSelected.BackColor = System.Drawing.Color.Red;
            this.panelProjekcijaSelected.Enabled = false;
            this.panelProjekcijaSelected.ForeColor = System.Drawing.Color.White;
            this.panelProjekcijaSelected.Location = new System.Drawing.Point(3, 372);
            this.panelProjekcijaSelected.Name = "panelProjekcijaSelected";
            this.panelProjekcijaSelected.Size = new System.Drawing.Size(6, 50);
            this.panelProjekcijaSelected.TabIndex = 3;
            this.panelProjekcijaSelected.Visible = false;
            // 
            // panelZaposleniSelected
            // 
            this.panelZaposleniSelected.BackColor = System.Drawing.Color.Red;
            this.panelZaposleniSelected.ForeColor = System.Drawing.Color.White;
            this.panelZaposleniSelected.Location = new System.Drawing.Point(3, 205);
            this.panelZaposleniSelected.Name = "panelZaposleniSelected";
            this.panelZaposleniSelected.Size = new System.Drawing.Size(6, 50);
            this.panelZaposleniSelected.TabIndex = 2;
            // 
            // btnZanr
            // 
            this.btnZanr.FlatAppearance.BorderSize = 0;
            this.btnZanr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZanr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.ForeColor = System.Drawing.Color.White;
            this.btnZanr.Image = ((System.Drawing.Image)(resources.GetObject("btnZanr.Image")));
            this.btnZanr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZanr.Location = new System.Drawing.Point(12, 432);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(261, 50);
            this.btnZanr.TabIndex = 4;
            this.btnZanr.Text = "                ZANR";
            this.btnZanr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZanr.UseVisualStyleBackColor = true;
            // 
            // btnProjekcija
            // 
            this.btnProjekcija.FlatAppearance.BorderSize = 0;
            this.btnProjekcija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjekcija.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjekcija.ForeColor = System.Drawing.Color.White;
            this.btnProjekcija.Image = ((System.Drawing.Image)(resources.GetObject("btnProjekcija.Image")));
            this.btnProjekcija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjekcija.Location = new System.Drawing.Point(12, 374);
            this.btnProjekcija.Name = "btnProjekcija";
            this.btnProjekcija.Size = new System.Drawing.Size(261, 50);
            this.btnProjekcija.TabIndex = 3;
            this.btnProjekcija.Text = "            PROJEKCIJA";
            this.btnProjekcija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjekcija.UseVisualStyleBackColor = true;
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.FlatAppearance.BorderSize = 0;
            this.btnZaposleni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposleni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.ForeColor = System.Drawing.Color.White;
            this.btnZaposleni.Image = ((System.Drawing.Image)(resources.GetObject("btnZaposleni.Image")));
            this.btnZaposleni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposleni.Location = new System.Drawing.Point(12, 206);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(261, 50);
            this.btnZaposleni.TabIndex = 2;
            this.btnZaposleni.Text = "             ZAPOSLENI";
            this.btnZaposleni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZaposleni.UseVisualStyleBackColor = true;
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbPrikaz.Controls.Add(this.dgvPrikaz);
            this.gbPrikaz.Location = new System.Drawing.Point(586, 318);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(566, 370);
            this.gbPrikaz.TabIndex = 6;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Prikaz";
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvPrikaz.Location = new System.Drawing.Point(6, 19);
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikaz.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.dgvPrikaz.Size = new System.Drawing.Size(548, 345);
            this.dgvPrikaz.TabIndex = 0;
            this.dgvPrikaz.Click += new System.EventHandler(this.dgvPrikaz_Click);
            // 
            // gbPretraga
            // 
            this.gbPretraga.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbPretraga.Location = new System.Drawing.Point(586, 174);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(566, 136);
            this.gbPretraga.TabIndex = 7;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // gbDetaljno
            // 
            this.gbDetaljno.Controls.Add(this.toolStripKarta);
            this.gbDetaljno.Controls.Add(this.flpDetaljno);
            this.gbDetaljno.Location = new System.Drawing.Point(265, 174);
            this.gbDetaljno.Name = "gbDetaljno";
            this.gbDetaljno.Size = new System.Drawing.Size(315, 500);
            this.gbDetaljno.TabIndex = 8;
            this.gbDetaljno.TabStop = false;
            this.gbDetaljno.Text = "Detaljno";
            // 
            // toolStripKarta
            // 
            this.toolStripKarta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnIzmjein,
            this.tsbtnObrisi});
            this.toolStripKarta.Location = new System.Drawing.Point(3, 16);
            this.toolStripKarta.Name = "toolStripKarta";
            this.toolStripKarta.Size = new System.Drawing.Size(309, 25);
            this.toolStripKarta.TabIndex = 1;
            this.toolStripKarta.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAdd.Text = "Kreiraj kartu";
            // 
            // tsbtnIzmjein
            // 
            this.tsbtnIzmjein.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIzmjein.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIzmjein.Image")));
            this.tsbtnIzmjein.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIzmjein.Name = "tsbtnIzmjein";
            this.tsbtnIzmjein.Size = new System.Drawing.Size(23, 22);
            this.tsbtnIzmjein.Text = "toolStripButton2";
            // 
            // tsbtnObrisi
            // 
            this.tsbtnObrisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnObrisi.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnObrisi.Image")));
            this.tsbtnObrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnObrisi.Name = "tsbtnObrisi";
            this.tsbtnObrisi.Size = new System.Drawing.Size(23, 22);
            this.tsbtnObrisi.Text = "toolStripButton3";
            // 
            // flpDetaljno
            // 
            this.flpDetaljno.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDetaljno.Location = new System.Drawing.Point(7, 44);
            this.flpDetaljno.Name = "flpDetaljno";
            this.flpDetaljno.Size = new System.Drawing.Size(302, 450);
            this.flpDetaljno.TabIndex = 0;
            // 
            // AdministracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.gbDetaljno);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbPrikaz);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelCrvenaLinija);
            this.Controls.Add(this.panelMeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministracijaForm";
            this.Text = "AdministracijaForm";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.panelMeni.ResumeLayout(false);
            this.panelMeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).EndInit();
            this.gbPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.gbDetaljno.ResumeLayout(false);
            this.gbDetaljno.PerformLayout();
            this.toolStripKarta.ResumeLayout(false);
            this.toolStripKarta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblAdministracija;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Panel panelCrvenaLinija;
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Panel panelZanrSelected;
        private System.Windows.Forms.Panel panelProjekcijaSelected;
        private System.Windows.Forms.Panel panelZaposleniSelected;
        private System.Windows.Forms.Button btnZanr;
        private System.Windows.Forms.Button btnProjekcija;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Panel panelLoginSelected;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelFilmSelected;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pBoxAvatar;
        private System.Windows.Forms.GroupBox gbPrikaz;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.GroupBox gbDetaljno;
        private System.Windows.Forms.ToolStrip toolStripKarta;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnIzmjein;
        private System.Windows.Forms.ToolStripButton tsbtnObrisi;
        private System.Windows.Forms.FlowLayoutPanel flpDetaljno;
        private System.Windows.Forms.Panel panelTerminiSelected;
        private System.Windows.Forms.Button btnTermini;
    }
}