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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMeni = new System.Windows.Forms.Panel();
            this.pbIzvjestaji = new System.Windows.Forms.PictureBox();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pbZanr = new System.Windows.Forms.PictureBox();
            this.pbProjekcija = new System.Windows.Forms.PictureBox();
            this.pbTermini = new System.Windows.Forms.PictureBox();
            this.pbZaposleni = new System.Windows.Forms.PictureBox();
            this.pbFilm = new System.Windows.Forms.PictureBox();
            this.pBoxAvatar = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnTermini = new System.Windows.Forms.Button();
            this.btnProjekcija = new System.Windows.Forms.Button();
            this.btnZanr = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.gbDetaljno = new System.Windows.Forms.GroupBox();
            this.tsbtnObrisi = new System.Windows.Forms.Button();
            this.tsbtnIzmijeni = new System.Windows.Forms.Button();
            this.tsbtnAdd = new System.Windows.Forms.Button();
            this.flpDetaljno = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDugmici = new System.Windows.Forms.Panel();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSatKrug = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblPretragaFix = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzvjestaji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZanr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjekcija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZaposleni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).BeginInit();
            this.gbPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.gbDetaljno.SuspendLayout();
            this.panelDugmici.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panelMeni.Controls.Add(this.pbIzvjestaji);
            this.panelMeni.Controls.Add(this.btnIzvjestaji);
            this.panelMeni.Controls.Add(this.btnLogout);
            this.panelMeni.Controls.Add(this.pbLogin);
            this.panelMeni.Controls.Add(this.pbZanr);
            this.panelMeni.Controls.Add(this.pbProjekcija);
            this.panelMeni.Controls.Add(this.pbTermini);
            this.panelMeni.Controls.Add(this.pbZaposleni);
            this.panelMeni.Controls.Add(this.pbFilm);
            this.panelMeni.Controls.Add(this.pBoxAvatar);
            this.panelMeni.Controls.Add(this.lblAdmin);
            this.panelMeni.Controls.Add(this.lblKorisnickoIme);
            this.panelMeni.Controls.Add(this.btnZaposleni);
            this.panelMeni.Controls.Add(this.btnFilm);
            this.panelMeni.Controls.Add(this.btnTermini);
            this.panelMeni.Controls.Add(this.btnProjekcija);
            this.panelMeni.Controls.Add(this.btnZanr);
            this.panelMeni.Controls.Add(this.btnLogin);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(260, 700);
            this.panelMeni.TabIndex = 3;
            // 
            // pbIzvjestaji
            // 
            this.pbIzvjestaji.BackColor = System.Drawing.Color.Transparent;
            this.pbIzvjestaji.Image = global::Cinema.Properties.Resources.newspaper;
            this.pbIzvjestaji.Location = new System.Drawing.Point(27, 592);
            this.pbIzvjestaji.Name = "pbIzvjestaji";
            this.pbIzvjestaji.Size = new System.Drawing.Size(61, 42);
            this.pbIzvjestaji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIzvjestaji.TabIndex = 22;
            this.pbIzvjestaji.TabStop = false;
            this.pbIzvjestaji.MouseEnter += new System.EventHandler(this.btnIzvjestaji_MouseEnter);
            this.pbIzvjestaji.MouseLeave += new System.EventHandler(this.btnIzvjestaji_MouseLeave);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.FlatAppearance.BorderSize = 0;
            this.btnIzvjestaji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIzvjestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.White;
            this.btnIzvjestaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.Location = new System.Drawing.Point(13, 582);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(254, 60);
            this.btnIzvjestaji.TabIndex = 21;
            this.btnIzvjestaji.Text = "        IZVJEŠTAJI";
            this.btnIzvjestaji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            this.btnIzvjestaji.MouseEnter += new System.EventHandler(this.btnIzvjestaji_MouseEnter);
            this.btnIzvjestaji.MouseLeave += new System.EventHandler(this.btnIzvjestaji_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::Cinema.Properties.Resources.log_out;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(3, 661);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(39, 36);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogin.Image = global::Cinema.Properties.Resources.login;
            this.pbLogin.Location = new System.Drawing.Point(25, 528);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(61, 42);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogin.TabIndex = 19;
            this.pbLogin.TabStop = false;
            this.pbLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.pbLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // pbZanr
            // 
            this.pbZanr.BackColor = System.Drawing.Color.Transparent;
            this.pbZanr.Image = global::Cinema.Properties.Resources.drama;
            this.pbZanr.Location = new System.Drawing.Point(25, 459);
            this.pbZanr.Name = "pbZanr";
            this.pbZanr.Size = new System.Drawing.Size(61, 42);
            this.pbZanr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZanr.TabIndex = 18;
            this.pbZanr.TabStop = false;
            this.pbZanr.MouseEnter += new System.EventHandler(this.btnZanr_MouseEnter);
            this.pbZanr.MouseLeave += new System.EventHandler(this.btnZanr_MouseLeave);
            // 
            // pbProjekcija
            // 
            this.pbProjekcija.BackColor = System.Drawing.Color.Transparent;
            this.pbProjekcija.Image = global::Cinema.Properties.Resources.video_camera;
            this.pbProjekcija.Location = new System.Drawing.Point(25, 390);
            this.pbProjekcija.Name = "pbProjekcija";
            this.pbProjekcija.Size = new System.Drawing.Size(61, 42);
            this.pbProjekcija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProjekcija.TabIndex = 17;
            this.pbProjekcija.TabStop = false;
            this.pbProjekcija.MouseEnter += new System.EventHandler(this.btnProjekcija_MouseEnter);
            this.pbProjekcija.MouseLeave += new System.EventHandler(this.btnProjekcija_MouseLeave);
            // 
            // pbTermini
            // 
            this.pbTermini.BackColor = System.Drawing.Color.Transparent;
            this.pbTermini.Image = global::Cinema.Properties.Resources.calendar_with_a_clock_time_tools;
            this.pbTermini.Location = new System.Drawing.Point(25, 316);
            this.pbTermini.Name = "pbTermini";
            this.pbTermini.Size = new System.Drawing.Size(61, 42);
            this.pbTermini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTermini.TabIndex = 16;
            this.pbTermini.TabStop = false;
            this.pbTermini.MouseEnter += new System.EventHandler(this.btnTermini_MouseEnter);
            this.pbTermini.MouseLeave += new System.EventHandler(this.btnTermini_MouseLeave);
            // 
            // pbZaposleni
            // 
            this.pbZaposleni.BackColor = System.Drawing.Color.Transparent;
            this.pbZaposleni.Image = global::Cinema.Properties.Resources.employee;
            this.pbZaposleni.Location = new System.Drawing.Point(25, 178);
            this.pbZaposleni.Name = "pbZaposleni";
            this.pbZaposleni.Size = new System.Drawing.Size(61, 42);
            this.pbZaposleni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZaposleni.TabIndex = 14;
            this.pbZaposleni.TabStop = false;
            this.pbZaposleni.MouseEnter += new System.EventHandler(this.btnZaposleni_MouseEnter);
            this.pbZaposleni.MouseLeave += new System.EventHandler(this.btnZaposleni_MouseLeave);
            // 
            // pbFilm
            // 
            this.pbFilm.BackColor = System.Drawing.Color.Transparent;
            this.pbFilm.Image = global::Cinema.Properties.Resources.film_roll;
            this.pbFilm.Location = new System.Drawing.Point(25, 245);
            this.pbFilm.Name = "pbFilm";
            this.pbFilm.Size = new System.Drawing.Size(61, 42);
            this.pbFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilm.TabIndex = 15;
            this.pbFilm.TabStop = false;
            this.pbFilm.MouseEnter += new System.EventHandler(this.btnFilm_MouseEnter);
            this.pbFilm.MouseLeave += new System.EventHandler(this.btnFilm_MouseLeave);
            // 
            // pBoxAvatar
            // 
            this.pBoxAvatar.Image = global::Cinema.Properties.Resources.admin_with_cogwheels;
            this.pBoxAvatar.Location = new System.Drawing.Point(68, 12);
            this.pBoxAvatar.Name = "pBoxAvatar";
            this.pBoxAvatar.Size = new System.Drawing.Size(129, 103);
            this.pBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxAvatar.TabIndex = 13;
            this.pBoxAvatar.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAdmin.Location = new System.Drawing.Point(82, 143);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(50, 17);
            this.lblAdmin.TabIndex = 12;
            this.lblAdmin.Text = "Admin";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnickoIme.ForeColor = System.Drawing.Color.White;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(82, 121);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(100, 17);
            this.lblKorisnickoIme.TabIndex = 11;
            this.lblKorisnickoIme.Text = "Korisnicko ime";
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.FlatAppearance.BorderSize = 0;
            this.btnZaposleni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnZaposleni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposleni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposleni.ForeColor = System.Drawing.Color.White;
            this.btnZaposleni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposleni.Location = new System.Drawing.Point(3, 174);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(254, 54);
            this.btnZaposleni.TabIndex = 2;
            this.btnZaposleni.Text = "             ZAPOSLENI";
            this.btnZaposleni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.MouseEnter += new System.EventHandler(this.btnZaposleni_MouseEnter);
            this.btnZaposleni.MouseLeave += new System.EventHandler(this.btnZaposleni_MouseLeave);
            // 
            // btnFilm
            // 
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilm.Location = new System.Drawing.Point(3, 239);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(254, 56);
            this.btnFilm.TabIndex = 9;
            this.btnFilm.Text = "   FILM";
            this.btnFilm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.MouseEnter += new System.EventHandler(this.btnFilm_MouseEnter);
            this.btnFilm.MouseLeave += new System.EventHandler(this.btnFilm_MouseLeave);
            // 
            // btnTermini
            // 
            this.btnTermini.FlatAppearance.BorderSize = 0;
            this.btnTermini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTermini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermini.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermini.ForeColor = System.Drawing.Color.White;
            this.btnTermini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTermini.Location = new System.Drawing.Point(3, 307);
            this.btnTermini.Name = "btnTermini";
            this.btnTermini.Size = new System.Drawing.Size(254, 58);
            this.btnTermini.TabIndex = 11;
            this.btnTermini.Text = "         TERMINI";
            this.btnTermini.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTermini.UseVisualStyleBackColor = true;
            this.btnTermini.Click += new System.EventHandler(this.Btn_Click);
            this.btnTermini.MouseEnter += new System.EventHandler(this.btnTermini_MouseEnter);
            this.btnTermini.MouseLeave += new System.EventHandler(this.btnTermini_MouseLeave);
            // 
            // btnProjekcija
            // 
            this.btnProjekcija.FlatAppearance.BorderSize = 0;
            this.btnProjekcija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProjekcija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjekcija.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjekcija.ForeColor = System.Drawing.Color.White;
            this.btnProjekcija.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjekcija.Location = new System.Drawing.Point(3, 382);
            this.btnProjekcija.Name = "btnProjekcija";
            this.btnProjekcija.Size = new System.Drawing.Size(254, 58);
            this.btnProjekcija.TabIndex = 3;
            this.btnProjekcija.Text = "                 PROJEKCIJA";
            this.btnProjekcija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjekcija.UseVisualStyleBackColor = true;
            this.btnProjekcija.MouseEnter += new System.EventHandler(this.btnProjekcija_MouseEnter);
            this.btnProjekcija.MouseLeave += new System.EventHandler(this.btnProjekcija_MouseLeave);
            // 
            // btnZanr
            // 
            this.btnZanr.FlatAppearance.BorderSize = 0;
            this.btnZanr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnZanr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZanr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanr.ForeColor = System.Drawing.Color.White;
            this.btnZanr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZanr.Location = new System.Drawing.Point(3, 451);
            this.btnZanr.Name = "btnZanr";
            this.btnZanr.Size = new System.Drawing.Size(254, 60);
            this.btnZanr.TabIndex = 4;
            this.btnZanr.Text = "     ZANR";
            this.btnZanr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZanr.UseVisualStyleBackColor = true;
            this.btnZanr.MouseEnter += new System.EventHandler(this.btnZanr_MouseEnter);
            this.btnZanr.MouseLeave += new System.EventHandler(this.btnZanr_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(3, 518);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(254, 60);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "        LOGIN";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.BackColor = System.Drawing.Color.Transparent;
            this.gbPrikaz.Controls.Add(this.dgvPrikaz);
            this.gbPrikaz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrikaz.ForeColor = System.Drawing.Color.White;
            this.gbPrikaz.Location = new System.Drawing.Point(600, 106);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(552, 545);
            this.gbPrikaz.TabIndex = 6;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Prikaz";
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToAddRows = false;
            this.dgvPrikaz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
            this.dgvPrikaz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrikaz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrikaz.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrikaz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrikaz.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrikaz.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrikaz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrikaz.GridColor = System.Drawing.Color.Silver;
            this.dgvPrikaz.Location = new System.Drawing.Point(3, 19);
            this.dgvPrikaz.MultiSelect = false;
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPrikaz.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrikaz.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrikaz.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikaz.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPrikaz.Size = new System.Drawing.Size(546, 520);
            this.dgvPrikaz.TabIndex = 0;
            this.dgvPrikaz.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPrikaz_CellFormatting);
            this.dgvPrikaz.SelectionChanged += new System.EventHandler(this.dgvPrikaz_SelectionChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.White;
            this.lblPretraga.Location = new System.Drawing.Point(235, 70);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(79, 21);
            this.lblPretraga.TabIndex = 1;
            this.lblPretraga.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(239, 38);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(214, 29);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // gbDetaljno
            // 
            this.gbDetaljno.Controls.Add(this.tsbtnObrisi);
            this.gbDetaljno.Controls.Add(this.tsbtnIzmijeni);
            this.gbDetaljno.Controls.Add(this.tsbtnAdd);
            this.gbDetaljno.Controls.Add(this.flpDetaljno);
            this.gbDetaljno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetaljno.ForeColor = System.Drawing.Color.White;
            this.gbDetaljno.Location = new System.Drawing.Point(265, 106);
            this.gbDetaljno.Name = "gbDetaljno";
            this.gbDetaljno.Size = new System.Drawing.Size(332, 545);
            this.gbDetaljno.TabIndex = 8;
            this.gbDetaljno.TabStop = false;
            this.gbDetaljno.Text = "Detaljno";
            // 
            // tsbtnObrisi
            // 
            this.tsbtnObrisi.BackgroundImage = global::Cinema.Properties.Resources.delete;
            this.tsbtnObrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnObrisi.FlatAppearance.BorderSize = 0;
            this.tsbtnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tsbtnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnObrisi.Location = new System.Drawing.Point(128, 20);
            this.tsbtnObrisi.Name = "tsbtnObrisi";
            this.tsbtnObrisi.Size = new System.Drawing.Size(37, 23);
            this.tsbtnObrisi.TabIndex = 3;
            this.tsbtnObrisi.UseVisualStyleBackColor = true;
            this.tsbtnObrisi.Click += new System.EventHandler(this.tsbtnObrisi_Click);
            // 
            // tsbtnIzmijeni
            // 
            this.tsbtnIzmijeni.BackgroundImage = global::Cinema.Properties.Resources.pencil_edit_button;
            this.tsbtnIzmijeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnIzmijeni.FlatAppearance.BorderSize = 0;
            this.tsbtnIzmijeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tsbtnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnIzmijeni.Location = new System.Drawing.Point(77, 20);
            this.tsbtnIzmijeni.Name = "tsbtnIzmijeni";
            this.tsbtnIzmijeni.Size = new System.Drawing.Size(31, 23);
            this.tsbtnIzmijeni.TabIndex = 2;
            this.tsbtnIzmijeni.UseVisualStyleBackColor = true;
            this.tsbtnIzmijeni.Click += new System.EventHandler(this.tsbtnIzmijeni_Click);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.BackgroundImage = global::Cinema.Properties.Resources.add;
            this.tsbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtnAdd.FlatAppearance.BorderSize = 0;
            this.tsbtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tsbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsbtnAdd.Location = new System.Drawing.Point(18, 20);
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(32, 23);
            this.tsbtnAdd.TabIndex = 1;
            this.tsbtnAdd.UseVisualStyleBackColor = true;
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // flpDetaljno
            // 
            this.flpDetaljno.AutoScroll = true;
            this.flpDetaljno.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDetaljno.Location = new System.Drawing.Point(6, 52);
            this.flpDetaljno.Margin = new System.Windows.Forms.Padding(0);
            this.flpDetaljno.Name = "flpDetaljno";
            this.flpDetaljno.Size = new System.Drawing.Size(322, 490);
            this.flpDetaljno.TabIndex = 0;
            // 
            // panelDugmici
            // 
            this.panelDugmici.Controls.Add(this.btnOdustani);
            this.panelDugmici.Controls.Add(this.btnPotvrdi);
            this.panelDugmici.Location = new System.Drawing.Point(266, 661);
            this.panelDugmici.Name = "panelDugmici";
            this.panelDugmici.Size = new System.Drawing.Size(331, 39);
            this.panelDugmici.TabIndex = 9;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(193, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(135, 34);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(3, 2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(135, 34);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.lblDatum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSatKrug);
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Controls.Add(this.lblSat);
            this.panel1.Controls.Add(this.lblPretragaFix);
            this.panel1.Controls.Add(this.lblPretraga);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.txtPretraga);
            this.panel1.Location = new System.Drawing.Point(259, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 106);
            this.panel1.TabIndex = 10;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDatum.Location = new System.Drawing.Point(804, 64);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(47, 17);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(824, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lblSatKrug
            // 
            this.lblSatKrug.AutoSize = true;
            this.lblSatKrug.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatKrug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSatKrug.Location = new System.Drawing.Point(796, 32);
            this.lblSatKrug.Name = "lblSatKrug";
            this.lblSatKrug.Size = new System.Drawing.Size(98, 33);
            this.lblSatKrug.TabIndex = 5;
            this.lblSatKrug.Text = "label1";
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
            this.circularProgressBar1.Location = new System.Drawing.Point(781, 1);
            this.circularProgressBar1.MarqueeAnimationSpeed = 10000;
            this.circularProgressBar1.Maximum = 60;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 2;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(109, 99);
            this.circularProgressBar1.StartAngle = -90;
            this.circularProgressBar1.Step = 1000;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 4;
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
            this.lblSat.TabIndex = 3;
            // 
            // lblPretragaFix
            // 
            this.lblPretragaFix.AutoSize = true;
            this.lblPretragaFix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretragaFix.ForeColor = System.Drawing.Color.White;
            this.lblPretragaFix.Location = new System.Drawing.Point(198, 9);
            this.lblPretragaFix.Name = "lblPretragaFix";
            this.lblPretragaFix.Size = new System.Drawing.Size(83, 21);
            this.lblPretragaFix.TabIndex = 2;
            this.lblPretragaFix.Text = "Pretraga:";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Cinema.Properties.Resources.logo_cine_23_2147503279__1_1;
            this.pbLogo.Location = new System.Drawing.Point(7, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(185, 106);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AdministracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDugmici);
            this.Controls.Add(this.gbDetaljno);
            this.Controls.Add(this.gbPrikaz);
            this.Controls.Add(this.panelMeni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministracijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministracijaForm";
            this.panelMeni.ResumeLayout(false);
            this.panelMeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIzvjestaji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZanr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjekcija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZaposleni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxAvatar)).EndInit();
            this.gbPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.gbDetaljno.ResumeLayout(false);
            this.panelDugmici.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMeni;
        private System.Windows.Forms.Button btnZanr;
        private System.Windows.Forms.Button btnProjekcija;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.GroupBox gbPrikaz;
        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.GroupBox gbDetaljno;
        private System.Windows.Forms.FlowLayoutPanel flpDetaljno;
        private System.Windows.Forms.Button btnTermini;
        private System.Windows.Forms.PictureBox pBoxAvatar;
        private System.Windows.Forms.Panel panelDugmici;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbZanr;
        private System.Windows.Forms.PictureBox pbProjekcija;
        private System.Windows.Forms.PictureBox pbTermini;
        private System.Windows.Forms.PictureBox pbFilm;
        private System.Windows.Forms.PictureBox pbZaposleni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblPretragaFix;
        private System.Windows.Forms.Button tsbtnObrisi;
        private System.Windows.Forms.Button tsbtnIzmijeni;
        private System.Windows.Forms.Button tsbtnAdd;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pbIzvjestaji;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSatKrug;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatum;
    }
}