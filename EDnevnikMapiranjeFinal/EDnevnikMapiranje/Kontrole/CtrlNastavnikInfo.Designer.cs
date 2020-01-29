namespace EDnevnikMapiranje
{
    partial class CtrlNastavnikInfo
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
            this.lblPredmet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOdeljenje = new System.Windows.Forms.Label();
            this.gbUcenici = new System.Windows.Forms.GroupBox();
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZapisi = new System.Windows.Forms.Button();
            this.btnOpisna = new System.Windows.Forms.Button();
            this.lblBrojcaneOcene = new System.Windows.Forms.Label();
            this.lblOpisneOcene = new System.Windows.Forms.Label();
            this.cmbOpisnaOcena = new System.Windows.Forms.ComboBox();
            this.nudBrojcanaOcena = new System.Windows.Forms.NumericUpDown();
            this.gbUcenici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojcanaOcena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // lblPredmet
            // 
            this.lblPredmet.AutoSize = true;
            this.lblPredmet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPredmet.ForeColor = System.Drawing.Color.White;
            this.lblPredmet.Location = new System.Drawing.Point(95, 23);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(49, 19);
            this.lblPredmet.TabIndex = 1;
            this.lblPredmet.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(246, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odeljenje";
            // 
            // lbOdeljenje
            // 
            this.lbOdeljenje.AutoSize = true;
            this.lbOdeljenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbOdeljenje.ForeColor = System.Drawing.Color.White;
            this.lbOdeljenje.Location = new System.Drawing.Point(327, 23);
            this.lbOdeljenje.Name = "lbOdeljenje";
            this.lbOdeljenje.Size = new System.Drawing.Size(49, 19);
            this.lbOdeljenje.TabIndex = 3;
            this.lbOdeljenje.Text = "label4";
            // 
            // gbUcenici
            // 
            this.gbUcenici.Controls.Add(this.lbUcenici);
            this.gbUcenici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.gbUcenici.Location = new System.Drawing.Point(331, 73);
            this.gbUcenici.Name = "gbUcenici";
            this.gbUcenici.Size = new System.Drawing.Size(295, 383);
            this.gbUcenici.TabIndex = 4;
            this.gbUcenici.TabStop = false;
            this.gbUcenici.Text = "Ucenici";
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.ItemHeight = 19;
            this.lbUcenici.Location = new System.Drawing.Point(6, 25);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(283, 346);
            this.lbUcenici.TabIndex = 0;
            this.lbUcenici.SelectedIndexChanged += new System.EventHandler(this.lbUcenici_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikaz.Location = new System.Drawing.Point(20, 138);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(0, 20);
            this.lblPrikaz.TabIndex = 6;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.Maroon;
            this.btnNazad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNazad.ForeColor = System.Drawing.Color.White;
            this.btnNazad.Location = new System.Drawing.Point(480, 3);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(114, 27);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "Vrati se nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(12, 269);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(199, 28);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj Brojcanu Ocenu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZapisi
            // 
            this.btnZapisi.BackColor = System.Drawing.Color.Maroon;
            this.btnZapisi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnZapisi.ForeColor = System.Drawing.Color.White;
            this.btnZapisi.Location = new System.Drawing.Point(156, 426);
            this.btnZapisi.Name = "btnZapisi";
            this.btnZapisi.Size = new System.Drawing.Size(163, 30);
            this.btnZapisi.TabIndex = 10;
            this.btnZapisi.Text = "Upisi Ucenika";
            this.btnZapisi.UseVisualStyleBackColor = false;
            this.btnZapisi.Click += new System.EventHandler(this.btnZapisi_Click);
            // 
            // btnOpisna
            // 
            this.btnOpisna.BackColor = System.Drawing.Color.Maroon;
            this.btnOpisna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpisna.ForeColor = System.Drawing.Color.White;
            this.btnOpisna.Location = new System.Drawing.Point(12, 336);
            this.btnOpisna.Name = "btnOpisna";
            this.btnOpisna.Size = new System.Drawing.Size(199, 33);
            this.btnOpisna.TabIndex = 12;
            this.btnOpisna.Text = "Dodaj Opisnu Ocenu";
            this.btnOpisna.UseVisualStyleBackColor = false;
            this.btnOpisna.Click += new System.EventHandler(this.btnOpisna_Click);
            // 
            // lblBrojcaneOcene
            // 
            this.lblBrojcaneOcene.AutoSize = true;
            this.lblBrojcaneOcene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojcaneOcene.Location = new System.Drawing.Point(20, 198);
            this.lblBrojcaneOcene.Name = "lblBrojcaneOcene";
            this.lblBrojcaneOcene.Size = new System.Drawing.Size(0, 20);
            this.lblBrojcaneOcene.TabIndex = 13;
            // 
            // lblOpisneOcene
            // 
            this.lblOpisneOcene.AutoSize = true;
            this.lblOpisneOcene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisneOcene.Location = new System.Drawing.Point(20, 256);
            this.lblOpisneOcene.Name = "lblOpisneOcene";
            this.lblOpisneOcene.Size = new System.Drawing.Size(0, 20);
            this.lblOpisneOcene.TabIndex = 14;
            // 
            // cmbOpisnaOcena
            // 
            this.cmbOpisnaOcena.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbOpisnaOcena.FormattingEnabled = true;
            this.cmbOpisnaOcena.Items.AddRange(new object[] {
            "Veoma se istice",
            "Istice se",
            "Dobar",
            "Neuspesan"});
            this.cmbOpisnaOcena.Location = new System.Drawing.Point(12, 303);
            this.cmbOpisnaOcena.Name = "cmbOpisnaOcena";
            this.cmbOpisnaOcena.Size = new System.Drawing.Size(199, 27);
            this.cmbOpisnaOcena.TabIndex = 16;
            // 
            // nudBrojcanaOcena
            // 
            this.nudBrojcanaOcena.Location = new System.Drawing.Point(12, 243);
            this.nudBrojcanaOcena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBrojcanaOcena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojcanaOcena.Name = "nudBrojcanaOcena";
            this.nudBrojcanaOcena.Size = new System.Drawing.Size(199, 20);
            this.nudBrojcanaOcena.TabIndex = 17;
            this.nudBrojcanaOcena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CtrlNastavnikInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nudBrojcanaOcena);
            this.Controls.Add(this.cmbOpisnaOcena);
            this.Controls.Add(this.lblOpisneOcene);
            this.Controls.Add(this.lblBrojcaneOcene);
            this.Controls.Add(this.btnOpisna);
            this.Controls.Add(this.btnZapisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblPrikaz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbUcenici);
            this.Controls.Add(this.lbOdeljenje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.label1);
            this.Name = "CtrlNastavnikInfo";
            this.Size = new System.Drawing.Size(633, 472);
            this.Load += new System.EventHandler(this.CtrlNastavnikInfo_Load);
            this.gbUcenici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojcanaOcena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOdeljenje;
        private System.Windows.Forms.GroupBox gbUcenici;
        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZapisi;
        private System.Windows.Forms.Button btnOpisna;
        private System.Windows.Forms.Label lblBrojcaneOcene;
        private System.Windows.Forms.Label lblOpisneOcene;
        private System.Windows.Forms.ComboBox cmbOpisnaOcena;
        private System.Windows.Forms.NumericUpDown nudBrojcanaOcena;
    }
}
