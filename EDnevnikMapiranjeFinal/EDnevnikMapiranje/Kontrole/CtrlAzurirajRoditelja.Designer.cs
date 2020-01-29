namespace EDnevnikMapiranje
{
    partial class CtrlAzurirajRoditelja
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
            this.lbRoditelji = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatumDoUSavetu = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatumOdUSavetu = new System.Windows.Forms.DateTimePicker();
            this.cbUSavetu = new System.Windows.Forms.CheckBox();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJmgb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAzurirajRoditelja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRoditelji
            // 
            this.lbRoditelji.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoditelji.FormattingEnabled = true;
            this.lbRoditelji.ItemHeight = 19;
            this.lbRoditelji.Location = new System.Drawing.Point(3, 3);
            this.lbRoditelji.Name = "lbRoditelji";
            this.lbRoditelji.Size = new System.Drawing.Size(156, 175);
            this.lbRoditelji.TabIndex = 0;
            this.lbRoditelji.SelectedIndexChanged += new System.EventHandler(this.lbRoditelji_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(122, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 19);
            this.label10.TabIndex = 66;
            this.label10.Text = "Datum Do U Savetu";
            // 
            // dtpDatumDoUSavetu
            // 
            this.dtpDatumDoUSavetu.Location = new System.Drawing.Point(269, 286);
            this.dtpDatumDoUSavetu.Name = "dtpDatumDoUSavetu";
            this.dtpDatumDoUSavetu.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDoUSavetu.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(122, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 64;
            this.label9.Text = "Datum Od U Savetu";
            // 
            // dtpDatumOdUSavetu
            // 
            this.dtpDatumOdUSavetu.Location = new System.Drawing.Point(269, 260);
            this.dtpDatumOdUSavetu.Name = "dtpDatumOdUSavetu";
            this.dtpDatumOdUSavetu.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOdUSavetu.TabIndex = 63;
            // 
            // cbUSavetu
            // 
            this.cbUSavetu.AutoSize = true;
            this.cbUSavetu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbUSavetu.ForeColor = System.Drawing.Color.White;
            this.cbUSavetu.Location = new System.Drawing.Point(247, 231);
            this.cbUSavetu.Name = "cbUSavetu";
            this.cbUSavetu.Size = new System.Drawing.Size(89, 23);
            this.cbUSavetu.TabIndex = 62;
            this.cbUSavetu.Text = "U Savetu";
            this.cbUSavetu.UseVisualStyleBackColor = true;
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbZensko.ForeColor = System.Drawing.Color.White;
            this.rbZensko.Location = new System.Drawing.Point(247, 202);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(76, 23);
            this.rbZensko.TabIndex = 61;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbMusko.ForeColor = System.Drawing.Color.White;
            this.rbMusko.Location = new System.Drawing.Point(247, 173);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(75, 23);
            this.rbMusko.TabIndex = 60;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Musko";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(165, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Datum Rodjenja";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(283, 121);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRodjenja.TabIndex = 58;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(283, 147);
            this.txtBrojTelefona.MaxLength = 12;
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTelefona.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(165, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "Broj Telefona";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(283, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(165, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Email";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(283, 69);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(283, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ime";
            // 
            // txtJmgb
            // 
            this.txtJmgb.Location = new System.Drawing.Point(283, 15);
            this.txtJmgb.MaxLength = 13;
            this.txtJmgb.Name = "txtJmgb";
            this.txtJmgb.Size = new System.Drawing.Size(100, 20);
            this.txtJmgb.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "JMBG";
            // 
            // btnAzurirajRoditelja
            // 
            this.btnAzurirajRoditelja.BackColor = System.Drawing.Color.Maroon;
            this.btnAzurirajRoditelja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAzurirajRoditelja.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajRoditelja.Location = new System.Drawing.Point(256, 312);
            this.btnAzurirajRoditelja.Name = "btnAzurirajRoditelja";
            this.btnAzurirajRoditelja.Size = new System.Drawing.Size(80, 33);
            this.btnAzurirajRoditelja.TabIndex = 43;
            this.btnAzurirajRoditelja.Text = "Azuriraj";
            this.btnAzurirajRoditelja.UseVisualStyleBackColor = false;
            this.btnAzurirajRoditelja.Click += new System.EventHandler(this.btnAzurirajRoditelja_Click);
            // 
            // CtrlAzurirajRoditelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDatumDoUSavetu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDatumOdUSavetu);
            this.Controls.Add(this.cbUSavetu);
            this.Controls.Add(this.rbZensko);
            this.Controls.Add(this.rbMusko);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJmgb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzurirajRoditelja);
            this.Controls.Add(this.lbRoditelji);
            this.Name = "CtrlAzurirajRoditelja";
            this.Size = new System.Drawing.Size(498, 384);
            this.Load += new System.EventHandler(this.CtrlAzurirajRoditelja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRoditelji;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDatumDoUSavetu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatumOdUSavetu;
        private System.Windows.Forms.CheckBox cbUSavetu;
        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJmgb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAzurirajRoditelja;
    }
}
