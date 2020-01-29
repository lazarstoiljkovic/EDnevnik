namespace EDnevnikMapiranje
{
    partial class CtrlDodajJeRazredni
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
            this.lbNastavnik = new System.Windows.Forms.ListBox();
            this.lbOdeljenja = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpDatumOdRazredni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumDoRazredni = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbNastavnik
            // 
            this.lbNastavnik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNastavnik.FormattingEnabled = true;
            this.lbNastavnik.ItemHeight = 19;
            this.lbNastavnik.Location = new System.Drawing.Point(2, 0);
            this.lbNastavnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbNastavnik.Name = "lbNastavnik";
            this.lbNastavnik.Size = new System.Drawing.Size(187, 156);
            this.lbNastavnik.TabIndex = 0;
            // 
            // lbOdeljenja
            // 
            this.lbOdeljenja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbOdeljenja.FormattingEnabled = true;
            this.lbOdeljenja.ItemHeight = 19;
            this.lbOdeljenja.Location = new System.Drawing.Point(193, 0);
            this.lbOdeljenja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbOdeljenja.Name = "lbOdeljenja";
            this.lbOdeljenja.Size = new System.Drawing.Size(162, 156);
            this.lbOdeljenja.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(133, 213);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 46);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // dtpDatumOdRazredni
            // 
            this.dtpDatumOdRazredni.Location = new System.Drawing.Point(193, 166);
            this.dtpDatumOdRazredni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumOdRazredni.Name = "dtpDatumOdRazredni";
            this.dtpDatumOdRazredni.Size = new System.Drawing.Size(151, 20);
            this.dtpDatumOdRazredni.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum Od Razredni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum Do Razredni";
            // 
            // dtpDatumDoRazredni
            // 
            this.dtpDatumDoRazredni.Location = new System.Drawing.Point(193, 189);
            this.dtpDatumDoRazredni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDatumDoRazredni.Name = "dtpDatumDoRazredni";
            this.dtpDatumDoRazredni.Size = new System.Drawing.Size(151, 20);
            this.dtpDatumDoRazredni.TabIndex = 5;
            // 
            // CtrlDodajJeRazredni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumDoRazredni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumOdRazredni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbOdeljenja);
            this.Controls.Add(this.lbNastavnik);
            this.Name = "CtrlDodajJeRazredni";
            this.Size = new System.Drawing.Size(371, 261);
            this.Load += new System.EventHandler(this.CtrlDodajJeRazredni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNastavnik;
        private System.Windows.Forms.ListBox lbOdeljenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtpDatumOdRazredni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumDoRazredni;
    }
}
