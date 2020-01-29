namespace EDnevnikMapiranje
{
    partial class CtrlNastavnik
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
            this.lblStepenSS = new System.Windows.Forms.Label();
            this.lblRazredni = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbOdeljenja = new System.Windows.Forms.ComboBox();
            this.btnPregled = new System.Windows.Forms.Button();
            this.lbOdeljenja = new System.Windows.Forms.Label();
            this.lbPredmeti = new System.Windows.Forms.Label();
            this.btnDodajPlanIProgram = new System.Windows.Forms.Button();
            this.txtPlanIprogram = new System.Windows.Forms.TextBox();
            this.btnRazredniStaresina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblImePrezime.ForeColor = System.Drawing.Color.White;
            this.lblImePrezime.Location = new System.Drawing.Point(16, 11);
            this.lblImePrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(49, 19);
            this.lblImePrezime.TabIndex = 0;
            this.lblImePrezime.Text = "label1";
            // 
            // lblStepenSS
            // 
            this.lblStepenSS.AutoSize = true;
            this.lblStepenSS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblStepenSS.ForeColor = System.Drawing.Color.White;
            this.lblStepenSS.Location = new System.Drawing.Point(16, 36);
            this.lblStepenSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStepenSS.Name = "lblStepenSS";
            this.lblStepenSS.Size = new System.Drawing.Size(49, 19);
            this.lblStepenSS.TabIndex = 1;
            this.lblStepenSS.Text = "label1";
            // 
            // lblRazredni
            // 
            this.lblRazredni.AutoSize = true;
            this.lblRazredni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblRazredni.ForeColor = System.Drawing.Color.White;
            this.lblRazredni.Location = new System.Drawing.Point(18, 63);
            this.lblRazredni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazredni.Name = "lblRazredni";
            this.lblRazredni.Size = new System.Drawing.Size(49, 19);
            this.lblRazredni.TabIndex = 3;
            this.lblRazredni.Text = "label1";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(87, 132);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(110, 21);
            this.cmbPredmeti.TabIndex = 4;
            this.cmbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbPredmeti_SelectedIndexChanged);
            // 
            // cmbOdeljenja
            // 
            this.cmbOdeljenja.FormattingEnabled = true;
            this.cmbOdeljenja.Location = new System.Drawing.Point(522, 132);
            this.cmbOdeljenja.Name = "cmbOdeljenja";
            this.cmbOdeljenja.Size = new System.Drawing.Size(121, 21);
            this.cmbOdeljenja.TabIndex = 5;
            // 
            // btnPregled
            // 
            this.btnPregled.BackColor = System.Drawing.Color.Maroon;
            this.btnPregled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnPregled.ForeColor = System.Drawing.Color.White;
            this.btnPregled.Location = new System.Drawing.Point(485, 92);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(158, 34);
            this.btnPregled.TabIndex = 6;
            this.btnPregled.Text = "Pregledaj Odeljenje";
            this.btnPregled.UseVisualStyleBackColor = false;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // lbOdeljenja
            // 
            this.lbOdeljenja.AutoSize = true;
            this.lbOdeljenja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbOdeljenja.ForeColor = System.Drawing.Color.White;
            this.lbOdeljenja.Location = new System.Drawing.Point(444, 134);
            this.lbOdeljenja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOdeljenja.Name = "lbOdeljenja";
            this.lbOdeljenja.Size = new System.Drawing.Size(73, 19);
            this.lbOdeljenja.TabIndex = 7;
            this.lbOdeljenja.Text = "Odeljenja";
            // 
            // lbPredmeti
            // 
            this.lbPredmeti.AutoSize = true;
            this.lbPredmeti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbPredmeti.ForeColor = System.Drawing.Color.White;
            this.lbPredmeti.Location = new System.Drawing.Point(10, 133);
            this.lbPredmeti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPredmeti.Name = "lbPredmeti";
            this.lbPredmeti.Size = new System.Drawing.Size(69, 19);
            this.lbPredmeti.TabIndex = 8;
            this.lbPredmeti.Text = "Predmeti";
            // 
            // btnDodajPlanIProgram
            // 
            this.btnDodajPlanIProgram.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajPlanIProgram.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajPlanIProgram.ForeColor = System.Drawing.Color.White;
            this.btnDodajPlanIProgram.Location = new System.Drawing.Point(14, 473);
            this.btnDodajPlanIProgram.Name = "btnDodajPlanIProgram";
            this.btnDodajPlanIProgram.Size = new System.Drawing.Size(197, 34);
            this.btnDodajPlanIProgram.TabIndex = 9;
            this.btnDodajPlanIProgram.Text = "Dodaj Plan i Program";
            this.btnDodajPlanIProgram.UseVisualStyleBackColor = false;
            this.btnDodajPlanIProgram.Click += new System.EventHandler(this.btnDodajPlanIProgram_Click);
            // 
            // txtPlanIprogram
            // 
            this.txtPlanIprogram.Location = new System.Drawing.Point(14, 170);
            this.txtPlanIprogram.Multiline = true;
            this.txtPlanIprogram.Name = "txtPlanIprogram";
            this.txtPlanIprogram.Size = new System.Drawing.Size(629, 297);
            this.txtPlanIprogram.TabIndex = 10;
            // 
            // btnRazredniStaresina
            // 
            this.btnRazredniStaresina.BackColor = System.Drawing.Color.Maroon;
            this.btnRazredniStaresina.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnRazredniStaresina.ForeColor = System.Drawing.Color.White;
            this.btnRazredniStaresina.Location = new System.Drawing.Point(14, 92);
            this.btnRazredniStaresina.Name = "btnRazredniStaresina";
            this.btnRazredniStaresina.Size = new System.Drawing.Size(183, 34);
            this.btnRazredniStaresina.TabIndex = 11;
            this.btnRazredniStaresina.Text = "Pregledaj svoje odeljenje";
            this.btnRazredniStaresina.UseVisualStyleBackColor = false;
            this.btnRazredniStaresina.Click += new System.EventHandler(this.btnRazredniStaresina_Click);
            // 
            // CtrlNastavnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRazredniStaresina);
            this.Controls.Add(this.txtPlanIprogram);
            this.Controls.Add(this.btnDodajPlanIProgram);
            this.Controls.Add(this.lbPredmeti);
            this.Controls.Add(this.lbOdeljenja);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.cmbOdeljenja);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.lblRazredni);
            this.Controls.Add(this.lblStepenSS);
            this.Controls.Add(this.lblImePrezime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CtrlNastavnik";
            this.Size = new System.Drawing.Size(646, 543);
            this.Load += new System.EventHandler(this.CtrlNastavnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.Label lblStepenSS;
        private System.Windows.Forms.Label lblRazredni;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.ComboBox cmbOdeljenja;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Label lbOdeljenja;
        private System.Windows.Forms.Label lbPredmeti;
        private System.Windows.Forms.Button btnDodajPlanIProgram;
        private System.Windows.Forms.TextBox txtPlanIprogram;
        private System.Windows.Forms.Button btnRazredniStaresina;
    }
}
