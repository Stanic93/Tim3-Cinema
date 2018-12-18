namespace Cinema.Controle
{
    partial class UserLookUpControl
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
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
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
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(73, 7);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(37, 20);
            this.txtKeyValue.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(116, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFind.Size = new System.Drawing.Size(33, 20);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(155, 7);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(137, 20);
            this.txtValue.TabIndex = 3;
            // 
            // UserLookUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtKeyValue);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UserLookUpControl";
            this.Size = new System.Drawing.Size(310, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtValue;
    }
}
