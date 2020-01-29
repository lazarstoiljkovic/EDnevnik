namespace EDnevnikMapiranje
{
    partial class CtrlBrisiDrziPredmetOdeljenju
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
            this.lbDrziPredmetOdeljenju = new System.Windows.Forms.ListBox();
            this.btnBrisiDrziPredmetOdeljenju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDrziPredmetOdeljenju
            // 
            this.lbDrziPredmetOdeljenju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrziPredmetOdeljenju.FormattingEnabled = true;
            this.lbDrziPredmetOdeljenju.ItemHeight = 19;
            this.lbDrziPredmetOdeljenju.Location = new System.Drawing.Point(3, 3);
            this.lbDrziPredmetOdeljenju.Name = "lbDrziPredmetOdeljenju";
            this.lbDrziPredmetOdeljenju.Size = new System.Drawing.Size(405, 289);
            this.lbDrziPredmetOdeljenju.TabIndex = 0;
            // 
            // btnBrisiDrziPredmetOdeljenju
            // 
            this.btnBrisiDrziPredmetOdeljenju.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisiDrziPredmetOdeljenju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrisiDrziPredmetOdeljenju.ForeColor = System.Drawing.Color.White;
            this.btnBrisiDrziPredmetOdeljenju.Location = new System.Drawing.Point(155, 298);
            this.btnBrisiDrziPredmetOdeljenju.Name = "btnBrisiDrziPredmetOdeljenju";
            this.btnBrisiDrziPredmetOdeljenju.Size = new System.Drawing.Size(89, 38);
            this.btnBrisiDrziPredmetOdeljenju.TabIndex = 1;
            this.btnBrisiDrziPredmetOdeljenju.Text = "Brisi";
            this.btnBrisiDrziPredmetOdeljenju.UseVisualStyleBackColor = false;
            this.btnBrisiDrziPredmetOdeljenju.Click += new System.EventHandler(this.btnBrisiDrziPredmetOdeljenju_Click);
            // 
            // CtrlBrisiDrziPredmetOdeljenju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrisiDrziPredmetOdeljenju);
            this.Controls.Add(this.lbDrziPredmetOdeljenju);
            this.Name = "CtrlBrisiDrziPredmetOdeljenju";
            this.Size = new System.Drawing.Size(422, 351);
            this.Load += new System.EventHandler(this.CtrlBrisiDrziPredmetOdeljenju_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDrziPredmetOdeljenju;
        private System.Windows.Forms.Button btnBrisiDrziPredmetOdeljenju;
    }
}
