namespace EDnevnikMapiranje
{
    partial class CtrlDnevnik
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).BeginInit();
            this.SuspendLayout();
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
            this.dgvDnevnik.Location = new System.Drawing.Point(4, 6);
            this.dgvDnevnik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDnevnik.Name = "dgvDnevnik";
            this.dgvDnevnik.Size = new System.Drawing.Size(992, 424);
            this.dgvDnevnik.TabIndex = 7;
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
            // CtrlDnevnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDnevnik);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CtrlDnevnik";
            this.Size = new System.Drawing.Size(1004, 441);
            this.Load += new System.EventHandler(this.CtrlDnevnik_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}
