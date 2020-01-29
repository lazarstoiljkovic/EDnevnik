namespace EDnevnikMapiranje
{
    partial class CtrlBrisiOdeljenje
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
            this.lbOdeljenja = new System.Windows.Forms.ListBox();
            this.btnBrisiOdeljenje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOdeljenja
            // 
            this.lbOdeljenja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbOdeljenja.FormattingEnabled = true;
            this.lbOdeljenja.ItemHeight = 19;
            this.lbOdeljenja.Location = new System.Drawing.Point(3, 3);
            this.lbOdeljenja.Name = "lbOdeljenja";
            this.lbOdeljenja.Size = new System.Drawing.Size(238, 213);
            this.lbOdeljenja.TabIndex = 0;
            // 
            // btnBrisiOdeljenje
            // 
            this.btnBrisiOdeljenje.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiOdeljenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiOdeljenje.ForeColor = System.Drawing.Color.White;
            this.btnBrisiOdeljenje.Location = new System.Drawing.Point(67, 242);
            this.btnBrisiOdeljenje.Name = "btnBrisiOdeljenje";
            this.btnBrisiOdeljenje.Size = new System.Drawing.Size(93, 48);
            this.btnBrisiOdeljenje.TabIndex = 1;
            this.btnBrisiOdeljenje.Text = "Brisi";
            this.btnBrisiOdeljenje.UseVisualStyleBackColor = false;
            this.btnBrisiOdeljenje.Click += new System.EventHandler(this.btnBrisiOdeljenje_Click);
            // 
            // CtrlBrisiOdeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiOdeljenje);
            this.Controls.Add(this.lbOdeljenja);
            this.Name = "CtrlBrisiOdeljenje";
            this.Size = new System.Drawing.Size(244, 307);
            this.Load += new System.EventHandler(this.CtrlBrisiOdeljenje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOdeljenja;
        private System.Windows.Forms.Button btnBrisiOdeljenje;
    }
}
