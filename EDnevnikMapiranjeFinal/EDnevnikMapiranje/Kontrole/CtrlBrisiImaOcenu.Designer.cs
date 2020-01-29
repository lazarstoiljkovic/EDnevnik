namespace EDnevnikMapiranje
{
    partial class CtrlBrisiImaOcenu
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
            this.lbImaOcenu = new System.Windows.Forms.ListBox();
            this.btnBrisiImaOcenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbImaOcenu
            // 
            this.lbImaOcenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbImaOcenu.FormattingEnabled = true;
            this.lbImaOcenu.ItemHeight = 19;
            this.lbImaOcenu.Location = new System.Drawing.Point(3, 3);
            this.lbImaOcenu.Name = "lbImaOcenu";
            this.lbImaOcenu.Size = new System.Drawing.Size(365, 232);
            this.lbImaOcenu.TabIndex = 0;
            // 
            // btnBrisiImaOcenu
            // 
            this.btnBrisiImaOcenu.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiImaOcenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiImaOcenu.ForeColor = System.Drawing.Color.White;
            this.btnBrisiImaOcenu.Location = new System.Drawing.Point(150, 247);
            this.btnBrisiImaOcenu.Name = "btnBrisiImaOcenu";
            this.btnBrisiImaOcenu.Size = new System.Drawing.Size(85, 40);
            this.btnBrisiImaOcenu.TabIndex = 1;
            this.btnBrisiImaOcenu.Text = "Brisi";
            this.btnBrisiImaOcenu.UseVisualStyleBackColor = false;
            this.btnBrisiImaOcenu.Click += new System.EventHandler(this.btnBrisiImaOcenu_Click);
            // 
            // CtrlBrisiImaOcenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiImaOcenu);
            this.Controls.Add(this.lbImaOcenu);
            this.Name = "CtrlBrisiImaOcenu";
            this.Size = new System.Drawing.Size(371, 290);
            this.Load += new System.EventHandler(this.CtrlBrisiImaOcenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbImaOcenu;
        private System.Windows.Forms.Button btnBrisiImaOcenu;
    }
}
