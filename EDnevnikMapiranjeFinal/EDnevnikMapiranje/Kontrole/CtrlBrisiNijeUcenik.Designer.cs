namespace EDnevnikMapiranje
{
    partial class CtrlBrisiNijeUcenik
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
            this.lbNijeUcenik = new System.Windows.Forms.ListBox();
            this.btnBrisiNijeUcenik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNijeUcenik
            // 
            this.lbNijeUcenik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNijeUcenik.FormattingEnabled = true;
            this.lbNijeUcenik.ItemHeight = 19;
            this.lbNijeUcenik.Location = new System.Drawing.Point(3, 3);
            this.lbNijeUcenik.Name = "lbNijeUcenik";
            this.lbNijeUcenik.Size = new System.Drawing.Size(283, 327);
            this.lbNijeUcenik.TabIndex = 0;
            // 
            // btnBrisiNijeUcenik
            // 
            this.btnBrisiNijeUcenik.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiNijeUcenik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiNijeUcenik.ForeColor = System.Drawing.Color.White;
            this.btnBrisiNijeUcenik.Location = new System.Drawing.Point(91, 365);
            this.btnBrisiNijeUcenik.Name = "btnBrisiNijeUcenik";
            this.btnBrisiNijeUcenik.Size = new System.Drawing.Size(102, 44);
            this.btnBrisiNijeUcenik.TabIndex = 1;
            this.btnBrisiNijeUcenik.Text = "Brisi";
            this.btnBrisiNijeUcenik.UseVisualStyleBackColor = false;
            this.btnBrisiNijeUcenik.Click += new System.EventHandler(this.btnBrisiNijeUcenik_Click);
            // 
            // CtrlBrisiNijeUcenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiNijeUcenik);
            this.Controls.Add(this.lbNijeUcenik);
            this.Name = "CtrlBrisiNijeUcenik";
            this.Size = new System.Drawing.Size(294, 447);
            this.Load += new System.EventHandler(this.CtrlBrisiNijeUcenik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNijeUcenik;
        private System.Windows.Forms.Button btnBrisiNijeUcenik;
    }
}
