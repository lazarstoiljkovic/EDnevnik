namespace EDnevnikMapiranje
{
    partial class CtrlAzurirajPredmet
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
            this.lbPredmeti = new System.Windows.Forms.ListBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.cbBlok = new System.Windows.Forms.CheckBox();
            this.cbLab = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbObavezni = new System.Windows.Forms.RadioButton();
            this.rbIzborni = new System.Windows.Forms.RadioButton();
            this.txtMinBrUcenika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrCasaNed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazred = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPredmeti
            // 
            this.lbPredmeti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPredmeti.FormattingEnabled = true;
            this.lbPredmeti.ItemHeight = 19;
            this.lbPredmeti.Location = new System.Drawing.Point(19, 15);
            this.lbPredmeti.Name = "lbPredmeti";
            this.lbPredmeti.Size = new System.Drawing.Size(140, 156);
            this.lbPredmeti.TabIndex = 0;
            this.lbPredmeti.SelectedIndexChanged += new System.EventHandler(this.lbPredmeti_SelectedIndexChanged);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Maroon;
            this.btnAzuriraj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAzuriraj.ForeColor = System.Drawing.Color.White;
            this.btnAzuriraj.Location = new System.Drawing.Point(249, 342);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(93, 35);
            this.btnAzuriraj.TabIndex = 29;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // cbBlok
            // 
            this.cbBlok.AutoSize = true;
            this.cbBlok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbBlok.ForeColor = System.Drawing.Color.White;
            this.cbBlok.Location = new System.Drawing.Point(182, 290);
            this.cbBlok.Name = "cbBlok";
            this.cbBlok.Size = new System.Drawing.Size(165, 23);
            this.cbBlok.TabIndex = 28;
            this.cbBlok.Text = "Da li je blok nastava";
            this.cbBlok.UseVisualStyleBackColor = true;
            // 
            // cbLab
            // 
            this.cbLab.AutoSize = true;
            this.cbLab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbLab.ForeColor = System.Drawing.Color.White;
            this.cbLab.Location = new System.Drawing.Point(182, 267);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(160, 23);
            this.cbLab.TabIndex = 27;
            this.cbLab.Text = "Da li ima Lab vezbe";
            this.cbLab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbObavezni);
            this.groupBox1.Controls.Add(this.rbIzborni);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(176, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 73);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip Predmeta";
            // 
            // rbObavezni
            // 
            this.rbObavezni.AutoSize = true;
            this.rbObavezni.Location = new System.Drawing.Point(6, 19);
            this.rbObavezni.Name = "rbObavezni";
            this.rbObavezni.Size = new System.Drawing.Size(89, 23);
            this.rbObavezni.TabIndex = 10;
            this.rbObavezni.TabStop = true;
            this.rbObavezni.Text = "Obavezni";
            this.rbObavezni.UseVisualStyleBackColor = true;
            this.rbObavezni.CheckedChanged += new System.EventHandler(this.rbObavezni_CheckedChanged);
            // 
            // rbIzborni
            // 
            this.rbIzborni.AutoSize = true;
            this.rbIzborni.Location = new System.Drawing.Point(6, 42);
            this.rbIzborni.Name = "rbIzborni";
            this.rbIzborni.Size = new System.Drawing.Size(73, 23);
            this.rbIzborni.TabIndex = 11;
            this.rbIzborni.TabStop = true;
            this.rbIzborni.Text = "Izborni";
            this.rbIzborni.UseVisualStyleBackColor = true;
            this.rbIzborni.CheckedChanged += new System.EventHandler(this.rbIzborni_CheckedChanged);
            // 
            // txtMinBrUcenika
            // 
            this.txtMinBrUcenika.Location = new System.Drawing.Point(331, 230);
            this.txtMinBrUcenika.Name = "txtMinBrUcenika";
            this.txtMinBrUcenika.Size = new System.Drawing.Size(100, 20);
            this.txtMinBrUcenika.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(173, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Min Broj Ucenika";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(331, 105);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 20);
            this.txtOpis.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(173, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Opis";
            // 
            // txtBrCasaNed
            // 
            this.txtBrCasaNed.Location = new System.Drawing.Point(331, 82);
            this.txtBrCasaNed.Name = "txtBrCasaNed";
            this.txtBrCasaNed.Size = new System.Drawing.Size(100, 20);
            this.txtBrCasaNed.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Broj Casova nedeljno";
            // 
            // txtRazred
            // 
            this.txtRazred.Location = new System.Drawing.Point(331, 57);
            this.txtRazred.Name = "txtRazred";
            this.txtRazred.Size = new System.Drawing.Size(100, 20);
            this.txtRazred.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Razred";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(331, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Naziv";
            // 
            // CtrlAzurirajPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.cbBlok);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMinBrUcenika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrCasaNed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRazred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPredmeti);
            this.Name = "CtrlAzurirajPredmet";
            this.Size = new System.Drawing.Size(434, 464);
            this.Load += new System.EventHandler(this.CtrlAzurirajPredmet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPredmeti;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.CheckBox cbBlok;
        private System.Windows.Forms.CheckBox cbLab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbObavezni;
        private System.Windows.Forms.RadioButton rbIzborni;
        private System.Windows.Forms.TextBox txtMinBrUcenika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrCasaNed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRazred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
    }
}
