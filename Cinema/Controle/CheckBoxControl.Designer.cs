namespace Cinema.Controle
{
    partial class CheckBoxControl
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
            this.lblcbNaziv = new System.Windows.Forms.Label();
            this.checkBoxZauzeto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblcbNaziv
            // 
            this.lblcbNaziv.AutoSize = true;
            this.lblcbNaziv.ForeColor = System.Drawing.Color.Black;
            this.lblcbNaziv.Location = new System.Drawing.Point(3, 9);
            this.lblcbNaziv.Name = "lblcbNaziv";
            this.lblcbNaziv.Size = new System.Drawing.Size(29, 13);
            this.lblcbNaziv.TabIndex = 0;
            this.lblcbNaziv.Text = "label";
            // 
            // checkBoxZauzeto
            // 
            this.checkBoxZauzeto.AutoSize = true;
            this.checkBoxZauzeto.Location = new System.Drawing.Point(208, 8);
            this.checkBoxZauzeto.Name = "checkBoxZauzeto";
            this.checkBoxZauzeto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxZauzeto.TabIndex = 1;
            this.checkBoxZauzeto.UseVisualStyleBackColor = true;
            // 
            // CheckBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxZauzeto);
            this.Controls.Add(this.lblcbNaziv);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CheckBoxControl";
            this.Size = new System.Drawing.Size(226, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcbNaziv;
        private System.Windows.Forms.CheckBox checkBoxZauzeto;
    }
}
