﻿namespace Cinema.Controle
{
    partial class RichTextBoxControl
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
            this.rtxtVrijednost = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(3, 77);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 17);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            this.lblNaziv.Click += new System.EventHandler(this.lblNaziv_Click);
            // 
            // rtxtVrijednost
            // 
            this.rtxtVrijednost.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxtVrijednost.Location = new System.Drawing.Point(48, 3);
            this.rtxtVrijednost.Name = "rtxtVrijednost";
            this.rtxtVrijednost.Size = new System.Drawing.Size(188, 174);
            this.rtxtVrijednost.TabIndex = 1;
            this.rtxtVrijednost.Text = "";
            // 
            // RichTextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxtVrijednost);
            this.Controls.Add(this.lblNaziv);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RichTextBoxControl";
            this.Size = new System.Drawing.Size(241, 181);
            this.Load += new System.EventHandler(this.RichTextBoxControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.RichTextBox rtxtVrijednost;
    }
}
