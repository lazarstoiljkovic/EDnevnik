namespace EDnevnikMapiranje
{
    partial class CtrlAzurirajOcenu
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
            this.btnDodajFunckiju = new System.Windows.Forms.Button();
            this.txtOpisna = new System.Windows.Forms.TextBox();
            this.txtBrojcana = new System.Windows.Forms.TextBox();
            this.rbOpisna = new System.Windows.Forms.RadioButton();
            this.rbBrojcana = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbOcene
            // 
            this.lbOcene.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOcene.FormattingEnabled = true;
            this.lbOcene.ItemHeight = 19;
            this.lbOcene.Location = new System.Drawing.Point(2, 2);
            this.lbOcene.Margin = new System.Windows.Forms.Padding(2);
            this.lbOcene.Name = "lbOcene";
            this.lbOcene.Size = new System.Drawing.Size(265, 118);
            this.lbOcene.TabIndex = 10;
            this.lbOcene.SelectedIndexChanged += new System.EventHandler(this.lbOcene_SelectedIndexChanged);
            // 
            // btnDodajFunckiju
            // 
            this.btnDodajFunckiju.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajFunckiju.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajFunckiju.ForeColor = System.Drawing.Color.White;
            this.btnDodajFunckiju.Location = new System.Drawing.Point(20, 207);
            this.btnDodajFunckiju.Name = "btnDodajFunckiju";
            this.btnDodajFunckiju.Size = new System.Drawing.Size(83, 37);
            this.btnDodajFunckiju.TabIndex = 9;
            this.btnDodajFunckiju.Text = "Azuriraj";
            this.btnDodajFunckiju.UseVisualStyleBackColor = false;
            this.btnDodajFunckiju.Click += new System.EventHandler(this.btnDodajFunckiju_Click);
            // 
            // txtOpisna
            // 
            this.txtOpisna.Location = new System.Drawing.Point(160, 178);
            this.txtOpisna.Name = "txtOpisna";
            this.txtOpisna.Size = new System.Drawing.Size(100, 20);
            this.txtOpisna.TabIndex = 14;
            // 
            // txtBrojcana
            // 
            this.txtBrojcana.Location = new System.Drawing.Point(160, 129);
            this.txtBrojcana.Name = "txtBrojcana";
            this.txtBrojcana.Size = new System.Drawing.Size(100, 20);
            this.txtBrojcana.TabIndex = 13;
            // 
            // rbOpisna
            // 
            this.rbOpisna.AutoSize = true;
            this.rbOpisna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbOpisna.ForeColor = System.Drawing.Color.White;
            this.rbOpisna.Location = new System.Drawing.Point(20, 178);
            this.rbOpisna.Name = "rbOpisna";
            this.rbOpisna.Size = new System.Drawing.Size(129, 23);
            this.rbOpisna.TabIndex = 12;
            this.rbOpisna.TabStop = true;
            this.rbOpisna.Text = "Opisana Ocena";
            this.rbOpisna.UseVisualStyleBackColor = true;
            // 
            // rbBrojcana
            // 
            this.rbBrojcana.AutoSize = true;
            this.rbBrojcana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.rbBrojcana.ForeColor = System.Drawing.Color.White;
            this.rbBrojcana.Location = new System.Drawing.Point(20, 129);
            this.rbBrojcana.Name = "rbBrojcana";
            this.rbBrojcana.Size = new System.Drawing.Size(134, 23);
            this.rbBrojcana.TabIndex = 11;
            this.rbBrojcana.TabStop = true;
            this.rbBrojcana.Text = "Brojcana Ocena";
            this.rbBrojcana.UseVisualStyleBackColor = true;
            // 
            // CtrlAzurirajOcenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOpisna);
            this.Controls.Add(this.txtBrojcana);
            this.Controls.Add(this.rbOpisna);
            this.Controls.Add(this.rbBrojcana);
            this.Controls.Add(this.lbOcene);
            this.Controls.Add(this.btnDodajFunckiju);
            this.Name = "CtrlAzurirajOcenu";
            this.Size = new System.Drawing.Size(269, 247);
            this.Load += new System.EventHandler(this.CtrlAzurirajOcenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOcene;
        private System.Windows.Forms.Button btnDodajFunckiju;
        private System.Windows.Forms.TextBox txtOpisna;
        private System.Windows.Forms.TextBox txtBrojcana;
        private System.Windows.Forms.RadioButton rbOpisna;
        private System.Windows.Forms.RadioButton rbBrojcana;
    }
}
