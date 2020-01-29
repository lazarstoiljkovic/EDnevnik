namespace EDnevnikMapiranje
{
    partial class CtrlDodajPredmet
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtRazred = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrCasaNed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinBrUcenika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbObavezni = new System.Windows.Forms.RadioButton();
            this.rbIzborni = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLab = new System.Windows.Forms.CheckBox();
            this.cbBlok = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(173, 17);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtRazred
            // 
            this.txtRazred.Location = new System.Drawing.Point(173, 43);
            this.txtRazred.Name = "txtRazred";
            this.txtRazred.Size = new System.Drawing.Size(100, 20);
            this.txtRazred.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razred";
            // 
            // txtBrCasaNed
            // 
            this.txtBrCasaNed.Location = new System.Drawing.Point(173, 69);
            this.txtBrCasaNed.Name = "txtBrCasaNed";
            this.txtBrCasaNed.Size = new System.Drawing.Size(100, 20);
            this.txtBrCasaNed.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj Casova nedeljno";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(173, 95);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 20);
            this.txtOpis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis";
            // 
            // txtMinBrUcenika
            // 
            this.txtMinBrUcenika.Location = new System.Drawing.Point(173, 217);
            this.txtMinBrUcenika.Name = "txtMinBrUcenika";
            this.txtMinBrUcenika.Size = new System.Drawing.Size(100, 20);
            this.txtMinBrUcenika.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min Broj Ucenika";
            // 
            // rbObavezni
            // 
            this.rbObavezni.AutoSize = true;
            this.rbObavezni.Location = new System.Drawing.Point(6, 19);
            this.rbObavezni.Name = "rbObavezni";
            this.rbObavezni.Size = new System.Drawing.Size(70, 17);
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
            this.rbIzborni.Size = new System.Drawing.Size(56, 17);
            this.rbIzborni.TabIndex = 11;
            this.rbIzborni.TabStop = true;
            this.rbIzborni.Text = "Izborni";
            this.rbIzborni.UseVisualStyleBackColor = true;
            this.rbIzborni.CheckedChanged += new System.EventHandler(this.rbIzborni_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbObavezni);
            this.groupBox1.Controls.Add(this.rbIzborni);
            this.groupBox1.Location = new System.Drawing.Point(66, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip Predmeta";
            // 
            // cbLab
            // 
            this.cbLab.AutoSize = true;
            this.cbLab.Location = new System.Drawing.Point(72, 253);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(119, 17);
            this.cbLab.TabIndex = 13;
            this.cbLab.Text = "Da li ima Lab vezbe";
            this.cbLab.UseVisualStyleBackColor = true;
            // 
            // cbBlok
            // 
            this.cbBlok.AutoSize = true;
            this.cbBlok.Location = new System.Drawing.Point(72, 276);
            this.cbBlok.Name = "cbBlok";
            this.cbBlok.Size = new System.Drawing.Size(122, 17);
            this.cbBlok.TabIndex = 14;
            this.cbBlok.Text = "Da li je blok nastava";
            this.cbBlok.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(139, 328);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // CtrlDodajPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
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
            this.Name = "CtrlDodajPredmet";
            this.Size = new System.Drawing.Size(357, 397);
            this.Load += new System.EventHandler(this.CtrlDodajPredmet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtRazred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrCasaNed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinBrUcenika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbObavezni;
        private System.Windows.Forms.RadioButton rbIzborni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLab;
        private System.Windows.Forms.CheckBox cbBlok;
        private System.Windows.Forms.Button btnDodaj;
    }
}
