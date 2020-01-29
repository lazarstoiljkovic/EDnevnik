namespace EDnevnikMapiranje
{
    partial class CtrlAzurirajAdministratora
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
            this.lbAdministratori = new System.Windows.Forms.ListBox();
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
            this.btnAzurirajAdministratora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAdministratori
            // 
            this.lbAdministratori.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbAdministratori.FormattingEnabled = true;
            this.lbAdministratori.ItemHeight = 19;
            this.lbAdministratori.Location = new System.Drawing.Point(3, 8);
            this.lbAdministratori.Name = "lbAdministratori";
            this.lbAdministratori.Size = new System.Drawing.Size(137, 289);
            this.lbAdministratori.TabIndex = 0;
            this.lbAdministratori.SelectedIndexChanged += new System.EventHandler(this.lbAdministratori_SelectedIndexChanged);
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbZensko.ForeColor = System.Drawing.Color.White;
            this.rbZensko.Location = new System.Drawing.Point(193, 196);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(76, 23);
            this.rbZensko.TabIndex = 56;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbMusko.ForeColor = System.Drawing.Color.White;
            this.rbMusko.Location = new System.Drawing.Point(193, 167);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(75, 23);
            this.rbMusko.TabIndex = 55;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Musko";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(146, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Datum Rodjenja";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(263, 115);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRodjenja.TabIndex = 53;
            this.dtpDatumRodjenja.ValueChanged += new System.EventHandler(this.DtpDatumRodjenja_ValueChanged);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(263, 141);
            this.txtBrojTelefona.MaxLength = 12;
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTelefona.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(146, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Broj Telefona";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(263, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(146, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Email";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(263, 63);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(263, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ime";
            // 
            // txtJmgb
            // 
            this.txtJmgb.Location = new System.Drawing.Point(263, 11);
            this.txtJmgb.MaxLength = 13;
            this.txtJmgb.Name = "txtJmgb";
            this.txtJmgb.Size = new System.Drawing.Size(100, 20);
            this.txtJmgb.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "JMBG";
            // 
            // btnAzurirajAdministratora
            // 
            this.btnAzurirajAdministratora.BackColor = System.Drawing.Color.Maroon;
            this.btnAzurirajAdministratora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAzurirajAdministratora.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajAdministratora.Location = new System.Drawing.Point(263, 225);
            this.btnAzurirajAdministratora.Name = "btnAzurirajAdministratora";
            this.btnAzurirajAdministratora.Size = new System.Drawing.Size(82, 28);
            this.btnAzurirajAdministratora.TabIndex = 38;
            this.btnAzurirajAdministratora.Text = "Azuriraj";
            this.btnAzurirajAdministratora.UseVisualStyleBackColor = false;
            this.btnAzurirajAdministratora.Click += new System.EventHandler(this.btnAzurirajAdministratora_Click);
            // 
            // CtrlAzurirajAdministratora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.btnAzurirajAdministratora);
            this.Controls.Add(this.lbAdministratori);
            this.Name = "CtrlAzurirajAdministratora";
            this.Size = new System.Drawing.Size(463, 305);
            this.Load += new System.EventHandler(this.CtrlAzurirajAdministratora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAdministratori;
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
        private System.Windows.Forms.Button btnAzurirajAdministratora;
    }
}
