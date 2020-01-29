namespace EDnevnikMapiranje
{
    partial class CtrlDrziPredmetOdeljenju
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
            this.Nastavnik = new System.Windows.Forms.ListBox();
            this.Predmet = new System.Windows.Forms.ListBox();
            this.Odeljenje = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nastavnik
            // 
            this.Nastavnik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nastavnik.FormattingEnabled = true;
            this.Nastavnik.ItemHeight = 19;
            this.Nastavnik.Location = new System.Drawing.Point(19, 28);
            this.Nastavnik.Name = "Nastavnik";
            this.Nastavnik.Size = new System.Drawing.Size(163, 194);
            this.Nastavnik.TabIndex = 0;
            // 
            // Predmet
            // 
            this.Predmet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Predmet.FormattingEnabled = true;
            this.Predmet.ItemHeight = 19;
            this.Predmet.Location = new System.Drawing.Point(188, 28);
            this.Predmet.Name = "Predmet";
            this.Predmet.Size = new System.Drawing.Size(177, 194);
            this.Predmet.TabIndex = 1;
            // 
            // Odeljenje
            // 
            this.Odeljenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Odeljenje.FormattingEnabled = true;
            this.Odeljenje.ItemHeight = 19;
            this.Odeljenje.Location = new System.Drawing.Point(371, 28);
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Size = new System.Drawing.Size(184, 194);
            this.Odeljenje.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(247, 228);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 44);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // CtrlDrziPredmetOdeljenju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.Odeljenje);
            this.Controls.Add(this.Predmet);
            this.Controls.Add(this.Nastavnik);
            this.Name = "CtrlDrziPredmetOdeljenju";
            this.Size = new System.Drawing.Size(558, 305);
            this.Load += new System.EventHandler(this.CtrlDrziPredmetOdeljenju_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Nastavnik;
        private System.Windows.Forms.ListBox Predmet;
        private System.Windows.Forms.ListBox Odeljenje;
        private System.Windows.Forms.Button btnDodaj;
    }
}
