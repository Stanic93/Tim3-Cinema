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
            this.lblNaziv.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(3, 7);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(41, 16);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(63, 3);
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.Size = new System.Drawing.Size(37, 20);
            this.txtKeyValue.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(108, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFind.Size = new System.Drawing.Size(33, 20);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "...";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(147, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(87, 20);
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
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserLookUpControl";
            this.Size = new System.Drawing.Size(241, 27);
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
