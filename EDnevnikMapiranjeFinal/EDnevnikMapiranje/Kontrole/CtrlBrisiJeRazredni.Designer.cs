namespace EDnevnikMapiranje
{
    partial class CtrlBrisiJeRazredni
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
            this.lbJeRazredni = new System.Windows.Forms.ListBox();
            this.btnBrisiJeRazredni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbJeRazredni
            // 
            this.lbJeRazredni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbJeRazredni.FormattingEnabled = true;
            this.lbJeRazredni.ItemHeight = 19;
            this.lbJeRazredni.Location = new System.Drawing.Point(3, 3);
            this.lbJeRazredni.Name = "lbJeRazredni";
            this.lbJeRazredni.Size = new System.Drawing.Size(349, 251);
            this.lbJeRazredni.TabIndex = 0;
            // 
            // btnBrisiJeRazredni
            // 
            this.btnBrisiJeRazredni.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiJeRazredni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiJeRazredni.ForeColor = System.Drawing.Color.White;
            this.btnBrisiJeRazredni.Location = new System.Drawing.Point(130, 282);
            this.btnBrisiJeRazredni.Name = "btnBrisiJeRazredni";
            this.btnBrisiJeRazredni.Size = new System.Drawing.Size(105, 33);
            this.btnBrisiJeRazredni.TabIndex = 1;
            this.btnBrisiJeRazredni.Text = "Brisi";
            this.btnBrisiJeRazredni.UseVisualStyleBackColor = false;
            this.btnBrisiJeRazredni.Click += new System.EventHandler(this.btnBrisiJeRazredni_Click);
            // 
            // CtrlBrisiJeRazredni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiJeRazredni);
            this.Controls.Add(this.lbJeRazredni);
            this.Name = "CtrlBrisiJeRazredni";
            this.Size = new System.Drawing.Size(352, 396);
            this.Load += new System.EventHandler(this.CtrlBrisiJeRazredni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbJeRazredni;
        private System.Windows.Forms.Button btnBrisiJeRazredni;
    }
}
