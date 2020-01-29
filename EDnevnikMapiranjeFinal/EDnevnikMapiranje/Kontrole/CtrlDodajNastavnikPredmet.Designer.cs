namespace EDnevnikMapiranje
{
    partial class CtrlDodajNastavnikPredmet
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Nastavnici = new System.Windows.Forms.ListBox();
            this.Predmeti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaniProgram = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(161, 308);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(85, 40);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Nastavnici
            // 
            this.Nastavnici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nastavnici.FormattingEnabled = true;
            this.Nastavnici.ItemHeight = 19;
            this.Nastavnici.Location = new System.Drawing.Point(41, 39);
            this.Nastavnici.Name = "Nastavnici";
            this.Nastavnici.Size = new System.Drawing.Size(176, 175);
            this.Nastavnici.TabIndex = 1;
            // 
            // Predmeti
            // 
            this.Predmeti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Predmeti.FormattingEnabled = true;
            this.Predmeti.ItemHeight = 19;
            this.Predmeti.Location = new System.Drawing.Point(223, 39);
            this.Predmeti.Name = "Predmeti";
            this.Predmeti.Size = new System.Drawing.Size(186, 175);
            this.Predmeti.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plan i program";
            // 
            // txtPlaniProgram
            // 
            this.txtPlaniProgram.Location = new System.Drawing.Point(134, 259);
            this.txtPlaniProgram.Name = "txtPlaniProgram";
            this.txtPlaniProgram.Size = new System.Drawing.Size(242, 20);
            this.txtPlaniProgram.TabIndex = 4;
            // 
            // CtrlDodajNastavnikPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPlaniProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Predmeti);
            this.Controls.Add(this.Nastavnici);
            this.Controls.Add(this.btnDodaj);
            this.Name = "CtrlDodajNastavnikPredmet";
            this.Size = new System.Drawing.Size(412, 372);
            this.Load += new System.EventHandler(this.CtrlDodajNastavnikPredmet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox Nastavnici;
        private System.Windows.Forms.ListBox Predmeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaniProgram;
    }
}
