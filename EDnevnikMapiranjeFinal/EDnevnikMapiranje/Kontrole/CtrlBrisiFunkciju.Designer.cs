namespace EDnevnikMapiranje
{
    partial class CtrlBrisiFunkciju
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
            this.btnBrisiFunkciju = new System.Windows.Forms.Button();
            this.lbFunkcije = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBrisiFunkciju
            // 
            this.btnBrisiFunkciju.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiFunkciju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiFunkciju.ForeColor = System.Drawing.Color.White;
            this.btnBrisiFunkciju.Location = new System.Drawing.Point(135, 203);
            this.btnBrisiFunkciju.Name = "btnBrisiFunkciju";
            this.btnBrisiFunkciju.Size = new System.Drawing.Size(89, 41);
            this.btnBrisiFunkciju.TabIndex = 3;
            this.btnBrisiFunkciju.Text = "Brisi";
            this.btnBrisiFunkciju.UseVisualStyleBackColor = false;
            this.btnBrisiFunkciju.Click += new System.EventHandler(this.BtnBrisiFunkciju_Click);
            // 
            // lbFunkcije
            // 
            this.lbFunkcije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbFunkcije.FormattingEnabled = true;
            this.lbFunkcije.ItemHeight = 19;
            this.lbFunkcije.Location = new System.Drawing.Point(3, 3);
            this.lbFunkcije.Name = "lbFunkcije";
            this.lbFunkcije.Size = new System.Drawing.Size(350, 194);
            this.lbFunkcije.TabIndex = 2;
            // 
            // CtrlBrisiFunkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiFunkciju);
            this.Controls.Add(this.lbFunkcije);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CtrlBrisiFunkciju";
            this.Size = new System.Drawing.Size(356, 279);
            this.Load += new System.EventHandler(this.CtrlBrisiFunkciju_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrisiFunkciju;
        private System.Windows.Forms.ListBox lbFunkcije;
    }
}
