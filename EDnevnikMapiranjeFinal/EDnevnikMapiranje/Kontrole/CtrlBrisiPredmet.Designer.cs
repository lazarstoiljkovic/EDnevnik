namespace EDnevnikMapiranje
{
    partial class CtrlBrisiPredmet
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
            this.btnBrisiPredmeti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPredmeti
            // 
            this.lbPredmeti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbPredmeti.FormattingEnabled = true;
            this.lbPredmeti.ItemHeight = 19;
            this.lbPredmeti.Location = new System.Drawing.Point(3, 3);
            this.lbPredmeti.Name = "lbPredmeti";
            this.lbPredmeti.Size = new System.Drawing.Size(229, 194);
            this.lbPredmeti.TabIndex = 0;
            // 
            // btnBrisiPredmeti
            // 
            this.btnBrisiPredmeti.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiPredmeti.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiPredmeti.ForeColor = System.Drawing.Color.White;
            this.btnBrisiPredmeti.Location = new System.Drawing.Point(62, 221);
            this.btnBrisiPredmeti.Name = "btnBrisiPredmeti";
            this.btnBrisiPredmeti.Size = new System.Drawing.Size(101, 45);
            this.btnBrisiPredmeti.TabIndex = 1;
            this.btnBrisiPredmeti.Text = "Brisi";
            this.btnBrisiPredmeti.UseVisualStyleBackColor = false;
            this.btnBrisiPredmeti.Click += new System.EventHandler(this.btnBrisiPredmeti_Click);
            // 
            // CtrlBrisiPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiPredmeti);
            this.Controls.Add(this.lbPredmeti);
            this.Name = "CtrlBrisiPredmet";
            this.Size = new System.Drawing.Size(235, 290);
            this.Load += new System.EventHandler(this.CtrlBrisiPredmet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPredmeti;
        private System.Windows.Forms.Button btnBrisiPredmeti;
    }
}
