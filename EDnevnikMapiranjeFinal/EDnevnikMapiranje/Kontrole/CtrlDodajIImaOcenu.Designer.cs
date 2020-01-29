namespace EDnevnikMapiranje
{
    partial class CtrlDodajIImaOcenu
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
            this.Ucenici = new System.Windows.Forms.ListBox();
            this.Ocene = new System.Windows.Forms.ListBox();
            this.Predmeti = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ucenici
            // 
            this.Ucenici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Ucenici.FormattingEnabled = true;
            this.Ucenici.ItemHeight = 19;
            this.Ucenici.Location = new System.Drawing.Point(25, 44);
            this.Ucenici.Name = "Ucenici";
            this.Ucenici.Size = new System.Drawing.Size(176, 137);
            this.Ucenici.TabIndex = 0;
            // 
            // Ocene
            // 
            this.Ocene.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Ocene.FormattingEnabled = true;
            this.Ocene.ItemHeight = 19;
            this.Ocene.Location = new System.Drawing.Point(207, 44);
            this.Ocene.Name = "Ocene";
            this.Ocene.Size = new System.Drawing.Size(159, 137);
            this.Ocene.TabIndex = 1;
            // 
            // Predmeti
            // 
            this.Predmeti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Predmeti.FormattingEnabled = true;
            this.Predmeti.ItemHeight = 19;
            this.Predmeti.Location = new System.Drawing.Point(372, 44);
            this.Predmeti.Name = "Predmeti";
            this.Predmeti.Size = new System.Drawing.Size(182, 137);
            this.Predmeti.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(236, 199);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(81, 32);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // CtrlDodajIImaOcenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.Predmeti);
            this.Controls.Add(this.Ocene);
            this.Controls.Add(this.Ucenici);
            this.Name = "CtrlDodajIImaOcenu";
            this.Size = new System.Drawing.Size(570, 255);
            this.Load += new System.EventHandler(this.CtrlDodajIImaOcenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Ucenici;
        private System.Windows.Forms.ListBox Ocene;
        private System.Windows.Forms.ListBox Predmeti;
        private System.Windows.Forms.Button btnDodaj;
    }
}
