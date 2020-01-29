namespace EDnevnikMapiranje
{
    partial class CtrlBrisiOcenu
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
            this.lbOcene = new System.Windows.Forms.ListBox();
            this.btnBrisiOcenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOcene
            // 
            this.lbOcene.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbOcene.FormattingEnabled = true;
            this.lbOcene.ItemHeight = 19;
            this.lbOcene.Location = new System.Drawing.Point(3, 3);
            this.lbOcene.Name = "lbOcene";
            this.lbOcene.Size = new System.Drawing.Size(242, 251);
            this.lbOcene.TabIndex = 0;
            // 
            // btnBrisiOcenu
            // 
            this.btnBrisiOcenu.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiOcenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiOcenu.ForeColor = System.Drawing.Color.White;
            this.btnBrisiOcenu.Location = new System.Drawing.Point(70, 277);
            this.btnBrisiOcenu.Name = "btnBrisiOcenu";
            this.btnBrisiOcenu.Size = new System.Drawing.Size(93, 46);
            this.btnBrisiOcenu.TabIndex = 1;
            this.btnBrisiOcenu.Text = "Brisi";
            this.btnBrisiOcenu.UseVisualStyleBackColor = false;
            this.btnBrisiOcenu.Click += new System.EventHandler(this.btnBrisiOcenu_Click);
            // 
            // CtrlBrisiOcenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiOcenu);
            this.Controls.Add(this.lbOcene);
            this.Name = "CtrlBrisiOcenu";
            this.Size = new System.Drawing.Size(248, 357);
            this.Load += new System.EventHandler(this.CtrlBrisiOcenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOcene;
        private System.Windows.Forms.Button btnBrisiOcenu;
    }
}
