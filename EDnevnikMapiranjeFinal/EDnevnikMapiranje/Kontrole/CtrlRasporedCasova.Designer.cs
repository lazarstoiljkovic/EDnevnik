namespace EDnevnikMapiranje.Kontrole
{
    partial class CtrlRasporedCasova
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
            this.txtRasporedCasova = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbOdeljenja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRasporedCasova
            // 
            this.txtRasporedCasova.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtRasporedCasova.Location = new System.Drawing.Point(19, 63);
            this.txtRasporedCasova.Multiline = true;
            this.txtRasporedCasova.Name = "txtRasporedCasova";
            this.txtRasporedCasova.Size = new System.Drawing.Size(660, 330);
            this.txtRasporedCasova.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(19, 3);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(84, 36);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbOdeljenja
            // 
            this.cmbOdeljenja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbOdeljenja.FormattingEnabled = true;
            this.cmbOdeljenja.Location = new System.Drawing.Point(147, 12);
            this.cmbOdeljenja.Name = "cmbOdeljenja";
            this.cmbOdeljenja.Size = new System.Drawing.Size(121, 27);
            this.cmbOdeljenja.TabIndex = 2;
            // 
            // CtrlRasporedCasova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbOdeljenja);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtRasporedCasova);
            this.Name = "CtrlRasporedCasova";
            this.Size = new System.Drawing.Size(682, 414);
            this.Load += new System.EventHandler(this.CtrlRasporedCasova_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRasporedCasova;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbOdeljenja;
    }
}
