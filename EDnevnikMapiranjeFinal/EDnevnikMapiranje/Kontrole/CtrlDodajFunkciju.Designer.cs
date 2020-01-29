namespace EDnevnikMapiranje
{
    partial class CtrlDodajFunkciju
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
            this.txtTipFunckije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajFunckiju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTipFunckije
            // 
            this.txtTipFunckije.Location = new System.Drawing.Point(107, 29);
            this.txtTipFunckije.Name = "txtTipFunckije";
            this.txtTipFunckije.Size = new System.Drawing.Size(91, 20);
            this.txtTipFunckije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip funkcije";
            // 
            // btnDodajFunckiju
            // 
            this.btnDodajFunckiju.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajFunckiju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajFunckiju.ForeColor = System.Drawing.Color.White;
            this.btnDodajFunckiju.Location = new System.Drawing.Point(76, 72);
            this.btnDodajFunckiju.Name = "btnDodajFunckiju";
            this.btnDodajFunckiju.Size = new System.Drawing.Size(67, 38);
            this.btnDodajFunckiju.TabIndex = 2;
            this.btnDodajFunckiju.Text = "Dodaj";
            this.btnDodajFunckiju.UseVisualStyleBackColor = false;
            this.btnDodajFunckiju.Click += new System.EventHandler(this.btnDodajFunckiju_Click);
            // 
            // CtrlDodajFunkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodajFunckiju);
            this.Controls.Add(this.txtTipFunckije);
            this.Controls.Add(this.label1);
            this.Name = "CtrlDodajFunkciju";
            this.Size = new System.Drawing.Size(226, 125);
            this.Load += new System.EventHandler(this.CtrlDodajFunkciju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipFunckije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajFunckiju;
    }
}
