namespace EDnevnikMapiranje
{
    partial class CtrlBrisiObavljaFunkciju
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
            this.lbObavljaFunkciju = new System.Windows.Forms.ListBox();
            this.btnBrisiObavljaFunkciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbObavljaFunkciju
            // 
            this.lbObavljaFunkciju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbObavljaFunkciju.FormattingEnabled = true;
            this.lbObavljaFunkciju.ItemHeight = 19;
            this.lbObavljaFunkciju.Location = new System.Drawing.Point(3, 3);
            this.lbObavljaFunkciju.Name = "lbObavljaFunkciju";
            this.lbObavljaFunkciju.Size = new System.Drawing.Size(304, 270);
            this.lbObavljaFunkciju.TabIndex = 0;
            // 
            // btnBrisiObavljaFunkciju
            // 
            this.btnBrisiObavljaFunkciju.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiObavljaFunkciju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiObavljaFunkciju.ForeColor = System.Drawing.Color.White;
            this.btnBrisiObavljaFunkciju.Location = new System.Drawing.Point(99, 318);
            this.btnBrisiObavljaFunkciju.Name = "btnBrisiObavljaFunkciju";
            this.btnBrisiObavljaFunkciju.Size = new System.Drawing.Size(92, 46);
            this.btnBrisiObavljaFunkciju.TabIndex = 1;
            this.btnBrisiObavljaFunkciju.Text = "Brisi";
            this.btnBrisiObavljaFunkciju.UseVisualStyleBackColor = false;
            this.btnBrisiObavljaFunkciju.Click += new System.EventHandler(this.button1_Click);
            // 
            // CtrlBrisiObavljaFunkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiObavljaFunkciju);
            this.Controls.Add(this.lbObavljaFunkciju);
            this.Name = "CtrlBrisiObavljaFunkciju";
            this.Size = new System.Drawing.Size(310, 381);
            this.Load += new System.EventHandler(this.CtrlBrisiObavljaFunkciju_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbObavljaFunkciju;
        private System.Windows.Forms.Button btnBrisiObavljaFunkciju;
    }
}
