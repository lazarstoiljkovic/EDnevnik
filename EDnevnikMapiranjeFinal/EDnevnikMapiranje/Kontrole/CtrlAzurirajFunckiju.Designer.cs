namespace EDnevnikMapiranje
{
    partial class CtrlAzurirajFunckiju
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
            this.btnDodajFunckiju = new System.Windows.Forms.Button();
            this.txtTipFunckije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFunckije = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodajFunckiju
            // 
            this.btnDodajFunckiju.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajFunckiju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajFunckiju.ForeColor = System.Drawing.Color.White;
            this.btnDodajFunckiju.Location = new System.Drawing.Point(107, 176);
            this.btnDodajFunckiju.Name = "btnDodajFunckiju";
            this.btnDodajFunckiju.Size = new System.Drawing.Size(73, 30);
            this.btnDodajFunckiju.TabIndex = 5;
            this.btnDodajFunckiju.Text = "Azuriraj";
            this.btnDodajFunckiju.UseVisualStyleBackColor = false;
            this.btnDodajFunckiju.Click += new System.EventHandler(this.BtnDodajFunckiju_Click);
            // 
            // txtTipFunckije
            // 
            this.txtTipFunckije.Location = new System.Drawing.Point(98, 132);
            this.txtTipFunckije.Name = "txtTipFunckije";
            this.txtTipFunckije.Size = new System.Drawing.Size(91, 20);
            this.txtTipFunckije.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tip funkcije";
            // 
            // lbFunckije
            // 
            this.lbFunckije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbFunckije.FormattingEnabled = true;
            this.lbFunckije.ItemHeight = 19;
            this.lbFunckije.Location = new System.Drawing.Point(2, 2);
            this.lbFunckije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbFunckije.Name = "lbFunckije";
            this.lbFunckije.Size = new System.Drawing.Size(286, 118);
            this.lbFunckije.TabIndex = 6;
            // 
            // CtrlAzurirajFunckiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbFunckije);
            this.Controls.Add(this.btnDodajFunckiju);
            this.Controls.Add(this.txtTipFunckije);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CtrlAzurirajFunckiju";
            this.Size = new System.Drawing.Size(290, 218);
            this.Load += new System.EventHandler(this.CtrlAzurirajFunckiju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajFunckiju;
        private System.Windows.Forms.TextBox txtTipFunckije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFunckije;
    }
}
