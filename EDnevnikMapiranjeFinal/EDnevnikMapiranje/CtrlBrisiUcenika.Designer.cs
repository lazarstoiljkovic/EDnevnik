namespace EDnevnikMapiranje
{
    partial class CtrlBrisiUcenika
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
            this.lbUcenici.ItemHeight = 16;
            this.lbUcenici.Location = new System.Drawing.Point(4, 4);
            this.lbUcenici.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(159, 116);
            this.lbUcenici.TabIndex = 0;
            this.lbUcenici.SelectedIndexChanged += new System.EventHandler(this.LbUcenici_SelectedIndexChanged);
            // 
            // btnBrisiUcenika
            // 
            this.btnBrisiUcenika.Location = new System.Drawing.Point(31, 128);
            this.btnBrisiUcenika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrisiUcenika.Name = "btnBrisiUcenika";
            this.btnBrisiUcenika.Size = new System.Drawing.Size(100, 28);
            this.btnBrisiUcenika.TabIndex = 1;
            this.btnBrisiUcenika.Text = "Brisi";
            this.btnBrisiUcenika.UseVisualStyleBackColor = true;
            this.btnBrisiUcenika.Click += new System.EventHandler(this.btnBrisiUcenika_Click);
            // 
            // CtrlBrisiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiUcenika);
            this.Controls.Add(this.lbUcenici);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CtrlBrisiUcenika";
            this.Size = new System.Drawing.Size(175, 172);
            this.Load += new System.EventHandler(this.CtrlBrisiUcenika_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUcenici;
        private System.Windows.Forms.Button btnBrisiUcenika;
    }
}
