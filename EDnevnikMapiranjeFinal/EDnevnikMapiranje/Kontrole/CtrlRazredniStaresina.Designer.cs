namespace EDnevnikMapiranje
{
    partial class CtrlRazredniStaresina
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.dgvDnevnik = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrpskiJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matematika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biologija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Geografija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Istroija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fizicko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Likovno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muzicko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngleskiJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NemackiJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrancuskiJezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fizika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hemija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myPanel = new System.Windows.Forms.Panel();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblOpis.ForeColor = System.Drawing.Color.White;
            this.lblOpis.Location = new System.Drawing.Point(130, 14);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(49, 19);
            this.lblOpis.TabIndex = 0;
            this.lblOpis.Text = "label1";
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.Maroon;
            this.btnNazad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnNazad.ForeColor = System.Drawing.Color.White;
            this.btnNazad.Location = new System.Drawing.Point(414, 9);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(140, 33);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "Vrati se Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // dgvDnevnik
            // 
            this.dgvDnevnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDnevnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.SrpskiJezik,
            this.Matematika,
            this.Biologija,
            this.Geografija,
            this.Istroija,
            this.Fizicko,
            this.Likovno,
            this.Muzicko,
            this.EngleskiJezik,
            this.NemackiJezik,
            this.FrancuskiJezik,
            this.Fizika,
            this.Hemija});
            this.dgvDnevnik.Location = new System.Drawing.Point(3, 48);
            this.dgvDnevnik.Name = "dgvDnevnik";
            this.dgvDnevnik.Size = new System.Drawing.Size(551, 426);
            this.dgvDnevnik.TabIndex = 6;
            this.dgvDnevnik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // SrpskiJezik
            // 
            this.SrpskiJezik.HeaderText = "Srpski jezik";
            this.SrpskiJezik.Name = "SrpskiJezik";
            // 
            // Matematika
            // 
            this.Matematika.HeaderText = "Matematika";
            this.Matematika.Name = "Matematika";
            // 
            // Biologija
            // 
            this.Biologija.HeaderText = "Biologija";
            this.Biologija.Name = "Biologija";
            // 
            // Geografija
            // 
            this.Geografija.HeaderText = "Geografija";
            this.Geografija.Name = "Geografija";
            // 
            // Istroija
            // 
            this.Istroija.HeaderText = "Istorija";
            this.Istroija.Name = "Istroija";
            // 
            // Fizicko
            // 
            this.Fizicko.HeaderText = "Fizicko";
            this.Fizicko.Name = "Fizicko";
            // 
            // Likovno
            // 
            this.Likovno.HeaderText = "Likovno";
            this.Likovno.Name = "Likovno";
            // 
            // Muzicko
            // 
            this.Muzicko.HeaderText = "Muzicko";
            this.Muzicko.Name = "Muzicko";
            // 
            // EngleskiJezik
            // 
            this.EngleskiJezik.HeaderText = "Engleski Jezik";
            this.EngleskiJezik.Name = "EngleskiJezik";
            // 
            // NemackiJezik
            // 
            this.NemackiJezik.HeaderText = "Nemacki Jezik";
            this.NemackiJezik.Name = "NemackiJezik";
            // 
            // FrancuskiJezik
            // 
            this.FrancuskiJezik.HeaderText = "Francuski Jezik";
            this.FrancuskiJezik.Name = "FrancuskiJezik";
            // 
            // Fizika
            // 
            this.Fizika.HeaderText = "Fizika";
            this.Fizika.Name = "Fizika";
            // 
            // Hemija
            // 
            this.Hemija.HeaderText = "Hemija";
            this.Hemija.Name = "Hemija";
            // 
            // myPanel
            // 
            this.myPanel.Location = new System.Drawing.Point(560, 48);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(508, 546);
            this.myPanel.TabIndex = 7;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.Maroon;
            this.btnAzuriraj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAzuriraj.ForeColor = System.Drawing.Color.White;
            this.btnAzuriraj.Location = new System.Drawing.Point(752, 9);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(136, 33);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(607, 9);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(139, 33);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // CtrlRazredniStaresina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.dgvDnevnik);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.lblOpis);
            this.Name = "CtrlRazredniStaresina";
            this.Size = new System.Drawing.Size(1082, 610);
            this.Load += new System.EventHandler(this.CtrlRazredniStaresina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.DataGridView dgvDnevnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrpskiJezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matematika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biologija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Geografija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Istroija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fizicko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Likovno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muzicko;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngleskiJezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn NemackiJezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrancuskiJezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fizika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hemija;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
    }
}
