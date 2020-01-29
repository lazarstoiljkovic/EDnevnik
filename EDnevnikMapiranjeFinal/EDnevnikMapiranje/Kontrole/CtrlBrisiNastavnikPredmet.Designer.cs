namespace EDnevnikMapiranje
{
    partial class CtrlBrisiNastavnikPredmet
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
            this.lbNastavnikPredmet = new System.Windows.Forms.ListBox();
            this.btnBrisiNastavnikPredmet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNastavnikPredmet
            // 
            this.lbNastavnikPredmet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbNastavnikPredmet.FormattingEnabled = true;
            this.lbNastavnikPredmet.ItemHeight = 19;
            this.lbNastavnikPredmet.Location = new System.Drawing.Point(3, 3);
            this.lbNastavnikPredmet.Name = "lbNastavnikPredmet";
            this.lbNastavnikPredmet.Size = new System.Drawing.Size(344, 289);
            this.lbNastavnikPredmet.TabIndex = 0;
            // 
            // btnBrisiNastavnikPredmet
            // 
            this.btnBrisiNastavnikPredmet.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiNastavnikPredmet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiNastavnikPredmet.ForeColor = System.Drawing.Color.White;
            this.btnBrisiNastavnikPredmet.Location = new System.Drawing.Point(132, 299);
            this.btnBrisiNastavnikPredmet.Name = "btnBrisiNastavnikPredmet";
            this.btnBrisiNastavnikPredmet.Size = new System.Drawing.Size(91, 43);
            this.btnBrisiNastavnikPredmet.TabIndex = 1;
            this.btnBrisiNastavnikPredmet.Text = "Brisi";
            this.btnBrisiNastavnikPredmet.UseVisualStyleBackColor = false;
            this.btnBrisiNastavnikPredmet.Click += new System.EventHandler(this.btnBrisiNastavnikPredmet_Click);
            // 
            // CtrlBrisiNastavnikPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiNastavnikPredmet);
            this.Controls.Add(this.lbNastavnikPredmet);
            this.Name = "CtrlBrisiNastavnikPredmet";
            this.Size = new System.Drawing.Size(350, 391);
            this.Load += new System.EventHandler(this.BrisiNastavnikPredmet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNastavnikPredmet;
        private System.Windows.Forms.Button btnBrisiNastavnikPredmet;
    }
}
