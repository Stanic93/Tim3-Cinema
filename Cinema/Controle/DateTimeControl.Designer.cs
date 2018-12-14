namespace Cinema.Controle
{
    partial class DateTimeControl
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.dtpVrijednost = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(3, 10);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(35, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            // 
            // dtpVrijednost
            // 
            this.dtpVrijednost.CustomFormat = "dd.MM.yyyy";
            this.dtpVrijednost.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVrijednost.Location = new System.Drawing.Point(179, 4);
            this.dtpVrijednost.Name = "dtpVrijednost";
            this.dtpVrijednost.Size = new System.Drawing.Size(116, 20);
            this.dtpVrijednost.TabIndex = 1;
            // 
            // DateTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpVrijednost);
            this.Controls.Add(this.lblNaziv);
            this.Name = "DateTimeControl";
            this.Size = new System.Drawing.Size(304, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.DateTimePicker dtpVrijednost;
    }
}
