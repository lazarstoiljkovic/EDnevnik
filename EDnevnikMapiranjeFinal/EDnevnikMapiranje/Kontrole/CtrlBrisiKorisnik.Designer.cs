namespace EDnevnikMapiranje
{
    partial class CtrlBrisiKorisnik
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
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.btnBrisiKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.ItemHeight = 19;
            this.lbKorisnici.Location = new System.Drawing.Point(3, 3);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.Size = new System.Drawing.Size(299, 251);
            this.lbKorisnici.TabIndex = 0;
            // 
            // btnBrisiKorisnika
            // 
            this.btnBrisiKorisnika.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiKorisnika.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiKorisnika.ForeColor = System.Drawing.Color.White;
            this.btnBrisiKorisnika.Location = new System.Drawing.Point(108, 260);
            this.btnBrisiKorisnika.Name = "btnBrisiKorisnika";
            this.btnBrisiKorisnika.Size = new System.Drawing.Size(82, 32);
            this.btnBrisiKorisnika.TabIndex = 1;
            this.btnBrisiKorisnika.Text = "Brisi";
            this.btnBrisiKorisnika.UseVisualStyleBackColor = false;
            this.btnBrisiKorisnika.Click += new System.EventHandler(this.btnBrisiKorisnika_Click);
            // 
            // CtrlBrisiKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiKorisnika);
            this.Controls.Add(this.lbKorisnici);
            this.Name = "CtrlBrisiKorisnik";
            this.Size = new System.Drawing.Size(305, 315);
            this.Load += new System.EventHandler(this.CtrlBrisiKorisnik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.Button btnBrisiKorisnika;
    }
}
