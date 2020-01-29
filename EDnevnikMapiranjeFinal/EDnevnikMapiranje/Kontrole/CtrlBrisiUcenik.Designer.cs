namespace EDnevnikMapiranje
{
    partial class CtrlBrisiUcenik
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
            this.btnBrisiUcenika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.Location = new System.Drawing.Point(3, 3);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(247, 225);
            this.lbUcenici.TabIndex = 0;
            // 
            // btnBrisiUcenika
            // 
            this.btnBrisiUcenika.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiUcenika.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiUcenika.ForeColor = System.Drawing.Color.White;
            this.btnBrisiUcenika.Location = new System.Drawing.Point(79, 241);
            this.btnBrisiUcenika.Name = "btnBrisiUcenika";
            this.btnBrisiUcenika.Size = new System.Drawing.Size(90, 39);
            this.btnBrisiUcenika.TabIndex = 1;
            this.btnBrisiUcenika.Text = "Brisi";
            this.btnBrisiUcenika.UseVisualStyleBackColor = false;
            this.btnBrisiUcenika.Click += new System.EventHandler(this.btnBrisiUcenika_Click);
            // 
            // CtrlBrisiUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiUcenika);
            this.Controls.Add(this.lbUcenici);
            this.Name = "CtrlBrisiUcenik";
            this.Size = new System.Drawing.Size(253, 333);
            this.Load += new System.EventHandler(this.CtrlBrisiUcenik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.Button btnBrisiUcenika;
    }
}
