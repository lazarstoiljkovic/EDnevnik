namespace EDnevnikMapiranje
{
    partial class CtrlRoditelj
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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.lblFunkcija = new System.Windows.Forms.Label();
            this.cmbDeca = new System.Windows.Forms.ComboBox();
            this.panelDnevnik = new System.Windows.Forms.Panel();
            this.lblime = new System.Windows.Forms.Label();
            this.lblSavet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblImePrezime.ForeColor = System.Drawing.Color.White;
            this.lblImePrezime.Location = new System.Drawing.Point(16, 11);
            this.lblImePrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(45, 19);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "label1";
            // 
            // lblFunkcija
            // 
            this.lblFunkcija.AutoSize = true;
            this.lblFunkcija.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblFunkcija.ForeColor = System.Drawing.Color.White;
            this.lblFunkcija.Location = new System.Drawing.Point(16, 56);
            this.lblFunkcija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFunkcija.Name = "lblFunkcija";
            this.lblFunkcija.Size = new System.Drawing.Size(45, 19);
            this.lblFunkcija.TabIndex = 2;
            this.lblFunkcija.Text = "label2";
            // 
            // cmbDeca
            // 
            this.cmbDeca.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbDeca.FormattingEnabled = true;
            this.cmbDeca.Location = new System.Drawing.Point(746, 39);
            this.cmbDeca.Name = "cmbDeca";
            this.cmbDeca.Size = new System.Drawing.Size(181, 27);
            this.cmbDeca.TabIndex = 4;
            this.cmbDeca.SelectedIndexChanged += new System.EventHandler(this.CmbDeca_SelectedIndexChanged);
            // 
            // panelDnevnik
            // 
            this.panelDnevnik.Location = new System.Drawing.Point(24, 78);
            this.panelDnevnik.Name = "panelDnevnik";
            this.panelDnevnik.Size = new System.Drawing.Size(802, 594);
            this.panelDnevnik.TabIndex = 5;
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblime.ForeColor = System.Drawing.Color.White;
            this.lblime.Location = new System.Drawing.Point(753, 87);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(0, 19);
            this.lblime.TabIndex = 6;
            // 
            // lblSavet
            // 
            this.lblSavet.AutoSize = true;
            this.lblSavet.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblSavet.ForeColor = System.Drawing.Color.White;
            this.lblSavet.Location = new System.Drawing.Point(20, 42);
            this.lblSavet.Name = "lblSavet";
            this.lblSavet.Size = new System.Drawing.Size(0, 19);
            this.lblSavet.TabIndex = 7;
            // 
            // CtrlRoditelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSavet);
            this.Controls.Add(this.lblime);
            this.Controls.Add(this.panelDnevnik);
            this.Controls.Add(this.cmbDeca);
            this.Controls.Add(this.lblFunkcija);
            this.Controls.Add(this.lblImePrezime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CtrlRoditelj";
            this.Size = new System.Drawing.Size(1040, 685);
            this.Load += new System.EventHandler(this.CtrlRoditelj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblFunkcija;
        private System.Windows.Forms.ComboBox cmbDeca;
        private System.Windows.Forms.Panel panelDnevnik;
        private System.Windows.Forms.Label lblime;
        private System.Windows.Forms.Label lblSavet;
    }
}
