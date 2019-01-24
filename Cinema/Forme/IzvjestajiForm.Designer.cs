namespace Cinema.Forme
{
    partial class IzvjestajiForm
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
            this.lbIzvjestaji = new System.Windows.Forms.ListBox();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.panelIzvjestaji = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelUcitajIzvjestaje = new System.Windows.Forms.Panel();
            this.panelUcitajIzvjestaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIzvjestaji
            // 
            this.lbIzvjestaji.FormattingEnabled = true;
            this.lbIzvjestaji.Location = new System.Drawing.Point(4, 3);
            this.lbIzvjestaji.Name = "lbIzvjestaji";
            this.lbIzvjestaji.Size = new System.Drawing.Size(178, 563);
            this.lbIzvjestaji.TabIndex = 0;
            this.lbIzvjestaji.SelectedIndexChanged += new System.EventHandler(this.lbIzvjestaji_SelectedIndexChanged);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnUcitaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUcitaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUcitaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitaj.ForeColor = System.Drawing.Color.White;
            this.btnUcitaj.Location = new System.Drawing.Point(4, 600);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(178, 31);
            this.btnUcitaj.TabIndex = 1;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = false;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // panelIzvjestaji
            // 
            this.panelIzvjestaji.Location = new System.Drawing.Point(208, 34);
            this.panelIzvjestaji.Name = "panelIzvjestaji";
            this.panelIzvjestaji.Size = new System.Drawing.Size(932, 654);
            this.panelIzvjestaji.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Cinema.Properties.Resources.x_mark;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(1119, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelUcitajIzvjestaje
            // 
            this.panelUcitajIzvjestaje.Controls.Add(this.btnUcitaj);
            this.panelUcitajIzvjestaje.Controls.Add(this.lbIzvjestaji);
            this.panelUcitajIzvjestaje.Location = new System.Drawing.Point(12, 34);
            this.panelUcitajIzvjestaje.Name = "panelUcitajIzvjestaje";
            this.panelUcitajIzvjestaje.Size = new System.Drawing.Size(190, 654);
            this.panelUcitajIzvjestaje.TabIndex = 3;
            // 
            // IzvjestajiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1152, 700);
            this.Controls.Add(this.panelUcitajIzvjestaje);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelIzvjestaji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IzvjestajiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvjestaji";
            this.panelUcitajIzvjestaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIzvjestaji;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Panel panelIzvjestaji;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelUcitajIzvjestaje;
    }
}