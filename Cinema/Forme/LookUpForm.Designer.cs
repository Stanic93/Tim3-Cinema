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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPregledLookUp = new System.Windows.Forms.DataGridView();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.panelOkvir = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledLookUp)).BeginInit();
            this.panelOkvir.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPregledLookUp
            // 
            this.dgvPregledLookUp.AllowUserToAddRows = false;
            this.dgvPregledLookUp.AllowUserToDeleteRows = false;
            this.dgvPregledLookUp.BackgroundColor = System.Drawing.Color.White;
            this.dgvPregledLookUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregledLookUp.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPregledLookUp.Location = new System.Drawing.Point(11, 12);
            this.dgvPregledLookUp.Name = "dgvPregledLookUp";
            this.dgvPregledLookUp.ReadOnly = true;
            this.dgvPregledLookUp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvPregledLookUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledLookUp.Size = new System.Drawing.Size(412, 210);
            this.dgvPregledLookUp.TabIndex = 0;
            this.dgvPregledLookUp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPregledLookUp_CellFormatting);
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIzaberi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIzaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzaberi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzaberi.ForeColor = System.Drawing.Color.White;
            this.btnIzaberi.Location = new System.Drawing.Point(11, 229);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(119, 33);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(145, 229);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(119, 33);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // panelOkvir
            // 
            this.panelOkvir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOkvir.Controls.Add(this.btnOdustani);
            this.panelOkvir.Controls.Add(this.btnIzaberi);
            this.panelOkvir.Controls.Add(this.dgvPregledLookUp);
            this.panelOkvir.Location = new System.Drawing.Point(2, 0);
            this.panelOkvir.Name = "panelOkvir";
            this.panelOkvir.Size = new System.Drawing.Size(434, 272);
            this.panelOkvir.TabIndex = 3;
            // 
            // LookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(437, 274);
            this.Controls.Add(this.panelOkvir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LookUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LookUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledLookUp)).EndInit();
            this.panelOkvir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledLookUp;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Panel panelOkvir;
    }
}