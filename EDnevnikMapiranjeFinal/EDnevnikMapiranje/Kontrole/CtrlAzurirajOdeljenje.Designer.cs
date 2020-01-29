namespace EDnevnikMapiranje
{
    partial class CtrlAzurirajOdeljenje
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
            this.lbOdeljenje = new System.Windows.Forms.ListBox();
            this.txtRaspored = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSmer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAzurirajOdeljenje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOdeljenje
            // 
            this.lbOdeljenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOdeljenje.FormattingEnabled = true;
            this.lbOdeljenje.ItemHeight = 19;
            this.lbOdeljenje.Location = new System.Drawing.Point(10, 2);
            this.lbOdeljenje.Margin = new System.Windows.Forms.Padding(2);
            this.lbOdeljenje.Name = "lbOdeljenje";
            this.lbOdeljenje.Size = new System.Drawing.Size(160, 99);
            this.lbOdeljenje.TabIndex = 0;
            // 
            // txtRaspored
            // 
            this.txtRaspored.Location = new System.Drawing.Point(121, 202);
            this.txtRaspored.Name = "txtRaspored";
            this.txtRaspored.Size = new System.Drawing.Size(100, 20);
            this.txtRaspored.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Raspored";
            // 
            // txtSmer
            // 
            this.txtSmer.Location = new System.Drawing.Point(121, 176);
            this.txtSmer.Name = "txtSmer";
            this.txtSmer.Size = new System.Drawing.Size(100, 20);
            this.txtSmer.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Smer";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(121, 150);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naziv";
            // 
            // btnAzurirajOdeljenje
            // 
            this.btnAzurirajOdeljenje.BackColor = System.Drawing.Color.Maroon;
            this.btnAzurirajOdeljenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAzurirajOdeljenje.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajOdeljenje.Location = new System.Drawing.Point(77, 254);
            this.btnAzurirajOdeljenje.Name = "btnAzurirajOdeljenje";
            this.btnAzurirajOdeljenje.Size = new System.Drawing.Size(93, 34);
            this.btnAzurirajOdeljenje.TabIndex = 7;
            this.btnAzurirajOdeljenje.Text = "Azuriraj";
            this.btnAzurirajOdeljenje.UseVisualStyleBackColor = false;
            this.btnAzurirajOdeljenje.Click += new System.EventHandler(this.btnAzurirajOdeljenje_Click);
            // 
            // CtrlAzurirajOdeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRaspored);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSmer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzurirajOdeljenje);
            this.Controls.Add(this.lbOdeljenje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CtrlAzurirajOdeljenje";
            this.Size = new System.Drawing.Size(287, 321);
            this.Load += new System.EventHandler(this.CtrlAzurirajOdeljenje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOdeljenje;
        private System.Windows.Forms.TextBox txtRaspored;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSmer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAzurirajOdeljenje;
    }
}
