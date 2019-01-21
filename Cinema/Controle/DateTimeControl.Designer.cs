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
            this.dtpVrijednost = new System.Windows.Forms.DateTimePicker();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpVrijednost
            // 
            this.dtpVrijednost.CustomFormat = "dd.MM.yyyy";
            this.dtpVrijednost.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpVrijednost.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVrijednost.Location = new System.Drawing.Point(148, 3);
            this.dtpVrijednost.Name = "dtpVrijednost";
            this.dtpVrijednost.Size = new System.Drawing.Size(90, 21);
            this.dtpVrijednost.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(3, 6);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 17);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "label1";
            // 
            // DateTimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.dtpVrijednost);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DateTimeControl";
            this.Size = new System.Drawing.Size(241, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpVrijednost;
        private System.Windows.Forms.Label lblNaziv;
    }
}
