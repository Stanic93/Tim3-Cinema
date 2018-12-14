namespace Cinema.Controle
{
    partial class RepertoarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDetaljno = new System.Windows.Forms.GroupBox();
            this.flpDetaljno = new System.Windows.Forms.FlowLayoutPanel();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDatum = new System.Windows.Forms.RadioButton();
            this.rbtnNaziv = new System.Windows.Forms.RadioButton();
            this.gbPregled = new System.Windows.Forms.GroupBox();
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.gbKarta = new System.Windows.Forms.GroupBox();
            this.btnNovaKarta = new System.Windows.Forms.Button();
            this.dtpDatumProdukcije = new System.Windows.Forms.DateTimePicker();
            this.lblDatumProdukcije = new System.Windows.Forms.Label();
            this.gbDetaljno.SuspendLayout();
            this.gbPretraga.SuspendLayout();
            this.gbPregled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.gbKarta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetaljno
            // 
            this.gbDetaljno.Controls.Add(this.flpDetaljno);
            this.gbDetaljno.Enabled = false;
            this.gbDetaljno.Location = new System.Drawing.Point(4, 4);
            this.gbDetaljno.Name = "gbDetaljno";
            this.gbDetaljno.Size = new System.Drawing.Size(312, 373);
            this.gbDetaljno.TabIndex = 0;
            this.gbDetaljno.TabStop = false;
            this.gbDetaljno.Text = "Detaljno";
            // 
            // flpDetaljno
            // 
            this.flpDetaljno.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDetaljno.Location = new System.Drawing.Point(7, 20);
            this.flpDetaljno.Name = "flpDetaljno";
            this.flpDetaljno.Size = new System.Drawing.Size(299, 347);
            this.flpDetaljno.TabIndex = 0;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.dateTimePicker1);
            this.gbPretraga.Controls.Add(this.btnPrikaziSve);
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.txtNaziv);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Controls.Add(this.rbtnDatum);
            this.gbPretraga.Controls.Add(this.rbtnNaziv);
            this.gbPretraga.Location = new System.Drawing.Point(322, 4);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(551, 90);
            this.gbPretraga.TabIndex = 1;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 35);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 12, 21, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(358, 61);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(97, 23);
            this.btnPrikaziSve.TabIndex = 7;
            this.btnPrikaziSve.Text = "Prikazi sve";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(159, 62);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(99, 22);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(129, 36);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(129, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // rbtnDatum
            // 
            this.rbtnDatum.AutoSize = true;
            this.rbtnDatum.Location = new System.Drawing.Point(290, 13);
            this.rbtnDatum.Name = "rbtnDatum";
            this.rbtnDatum.Size = new System.Drawing.Size(70, 17);
            this.rbtnDatum.TabIndex = 1;
            this.rbtnDatum.TabStop = true;
            this.rbtnDatum.Text = "Po datum";
            this.rbtnDatum.UseVisualStyleBackColor = true;
            // 
            // rbtnNaziv
            // 
            this.rbtnNaziv.AutoSize = true;
            this.rbtnNaziv.Location = new System.Drawing.Point(186, 13);
            this.rbtnNaziv.Name = "rbtnNaziv";
            this.rbtnNaziv.Size = new System.Drawing.Size(72, 17);
            this.rbtnNaziv.TabIndex = 0;
            this.rbtnNaziv.TabStop = true;
            this.rbtnNaziv.Text = "Po nazivu";
            this.rbtnNaziv.UseVisualStyleBackColor = true;
            // 
            // gbPregled
            // 
            this.gbPregled.Controls.Add(this.dgvPregled);
            this.gbPregled.Location = new System.Drawing.Point(325, 100);
            this.gbPregled.Name = "gbPregled";
            this.gbPregled.Size = new System.Drawing.Size(548, 399);
            this.gbPregled.TabIndex = 2;
            this.gbPregled.TabStop = false;
            this.gbPregled.Text = "Pregled";
            // 
            // dgvPregled
            // 
            this.dgvPregled.AllowUserToAddRows = false;
            this.dgvPregled.AllowUserToDeleteRows = false;
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregled.Location = new System.Drawing.Point(3, 16);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.ReadOnly = true;
            this.dgvPregled.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPregled.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPregled.RowTemplate.DefaultCellStyle.NullValue = "/";
            this.dgvPregled.Size = new System.Drawing.Size(542, 380);
            this.dgvPregled.TabIndex = 0;
            this.dgvPregled.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregled_CellClick);
            // 
            // gbKarta
            // 
            this.gbKarta.Controls.Add(this.btnNovaKarta);
            this.gbKarta.Controls.Add(this.dtpDatumProdukcije);
            this.gbKarta.Controls.Add(this.lblDatumProdukcije);
            this.gbKarta.Location = new System.Drawing.Point(4, 383);
            this.gbKarta.Name = "gbKarta";
            this.gbKarta.Size = new System.Drawing.Size(312, 119);
            this.gbKarta.TabIndex = 3;
            this.gbKarta.TabStop = false;
            this.gbKarta.Text = "Karta";
            // 
            // btnNovaKarta
            // 
            this.btnNovaKarta.Location = new System.Drawing.Point(143, 73);
            this.btnNovaKarta.Name = "btnNovaKarta";
            this.btnNovaKarta.Size = new System.Drawing.Size(149, 40);
            this.btnNovaKarta.TabIndex = 12;
            this.btnNovaKarta.Text = "Nova karta";
            this.btnNovaKarta.UseVisualStyleBackColor = true;
            // 
            // dtpDatumProdukcije
            // 
            this.dtpDatumProdukcije.Location = new System.Drawing.Point(143, 30);
            this.dtpDatumProdukcije.MaxDate = new System.DateTime(2018, 12, 21, 0, 0, 0, 0);
            this.dtpDatumProdukcije.MinDate = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            this.dtpDatumProdukcije.Name = "dtpDatumProdukcije";
            this.dtpDatumProdukcije.Size = new System.Drawing.Size(149, 20);
            this.dtpDatumProdukcije.TabIndex = 10;
            this.dtpDatumProdukcije.Value = new System.DateTime(2018, 12, 16, 0, 0, 0, 0);
            // 
            // lblDatumProdukcije
            // 
            this.lblDatumProdukcije.AutoSize = true;
            this.lblDatumProdukcije.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumProdukcije.Location = new System.Drawing.Point(23, 30);
            this.lblDatumProdukcije.Name = "lblDatumProdukcije";
            this.lblDatumProdukcije.Size = new System.Drawing.Size(114, 17);
            this.lblDatumProdukcije.TabIndex = 8;
            this.lblDatumProdukcije.Text = "Datum produkcije";
            // 
            // RepertoarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbKarta);
            this.Controls.Add(this.gbPregled);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.gbDetaljno);
            this.Name = "RepertoarControl";
            this.Size = new System.Drawing.Size(876, 502);
            this.gbDetaljno.ResumeLayout(false);
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.gbPregled.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.gbKarta.ResumeLayout(false);
            this.gbKarta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetaljno;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.GroupBox gbPregled;
        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.GroupBox gbKarta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrikaziSve;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDatum;
        private System.Windows.Forms.RadioButton rbtnNaziv;
        private System.Windows.Forms.Button btnNovaKarta;
        private System.Windows.Forms.DateTimePicker dtpDatumProdukcije;
        private System.Windows.Forms.Label lblDatumProdukcije;
        private System.Windows.Forms.FlowLayoutPanel flpDetaljno;
    }
}
