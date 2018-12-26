namespace Cinema
{
    partial class LookUpForm
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
            this.dgvPregledLookUp = new System.Windows.Forms.DataGridView();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledLookUp
            // 
            this.dgvPregledLookUp.AllowUserToAddRows = false;
            this.dgvPregledLookUp.AllowUserToDeleteRows = false;
            this.dgvPregledLookUp.BackgroundColor = System.Drawing.Color.White;
            this.dgvPregledLookUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledLookUp.Location = new System.Drawing.Point(13, 13);
            this.dgvPregledLookUp.Name = "dgvPregledLookUp";
            this.dgvPregledLookUp.ReadOnly = true;
            this.dgvPregledLookUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledLookUp.Size = new System.Drawing.Size(411, 209);
            this.dgvPregledLookUp.TabIndex = 0;
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(13, 229);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(119, 25);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(147, 229);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(119, 25);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // LookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 266);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzaberi);
            this.Controls.Add(this.dgvPregledLookUp);
            this.Name = "LookUpForm";
            this.Text = "LookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledLookUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledLookUp;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnOdustani;
    }
}