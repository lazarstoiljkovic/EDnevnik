namespace EDnevnikMapiranje
{
    partial class DodajUcenikuRoditeljOdeljenje
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
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRoditelji = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbUcenici
            // 
            this.lbUcenici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.ItemHeight = 19;
            this.lbUcenici.Location = new System.Drawing.Point(12, 14);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(206, 346);
            this.lbUcenici.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(239, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbRoditelji
            // 
            this.cmbRoditelji.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cmbRoditelji.FormattingEnabled = true;
            this.cmbRoditelji.Location = new System.Drawing.Point(224, 14);
            this.cmbRoditelji.Name = "cmbRoditelji";
            this.cmbRoditelji.Size = new System.Drawing.Size(189, 27);
            this.cmbRoditelji.TabIndex = 3;
            this.cmbRoditelji.SelectedIndexChanged += new System.EventHandler(this.CmbRoditelji_SelectedIndexChanged);
            // 
            // DodajUcenikuRoditeljOdeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbRoditelji);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbUcenici);
            this.Name = "DodajUcenikuRoditeljOdeljenje";
            this.Size = new System.Drawing.Size(490, 546);
            this.Load += new System.EventHandler(this.DodajUcenikuRoditeljOdeljenje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbRoditelji;
    }
}
