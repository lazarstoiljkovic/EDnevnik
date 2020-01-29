namespace EDnevnikMapiranje
{
    partial class CtrlDodajOcenu
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
            this.rbBrojcana = new System.Windows.Forms.RadioButton();
            this.rbOpisna = new System.Windows.Forms.RadioButton();
            this.txtBrojcana = new System.Windows.Forms.TextBox();
            this.txtOpisna = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbBrojcana
            // 
            this.rbBrojcana.AutoSize = true;
            this.rbBrojcana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBrojcana.ForeColor = System.Drawing.Color.White;
            this.rbBrojcana.Location = new System.Drawing.Point(13, 20);
            this.rbBrojcana.Name = "rbBrojcana";
            this.rbBrojcana.Size = new System.Drawing.Size(134, 23);
            this.rbBrojcana.TabIndex = 0;
            this.rbBrojcana.TabStop = true;
            this.rbBrojcana.Text = "Brojcana Ocena";
            this.rbBrojcana.UseVisualStyleBackColor = true;
            this.rbBrojcana.CheckedChanged += new System.EventHandler(this.rbBrojcana_CheckedChanged);
            // 
            // rbOpisna
            // 
            this.rbOpisna.AutoSize = true;
            this.rbOpisna.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpisna.ForeColor = System.Drawing.Color.White;
            this.rbOpisna.Location = new System.Drawing.Point(13, 69);
            this.rbOpisna.Name = "rbOpisna";
            this.rbOpisna.Size = new System.Drawing.Size(129, 23);
            this.rbOpisna.TabIndex = 1;
            this.rbOpisna.TabStop = true;
            this.rbOpisna.Text = "Opisana Ocena";
            this.rbOpisna.UseVisualStyleBackColor = true;
            this.rbOpisna.CheckedChanged += new System.EventHandler(this.rbOpisna_CheckedChanged);
            // 
            // txtBrojcana
            // 
            this.txtBrojcana.Location = new System.Drawing.Point(141, 20);
            this.txtBrojcana.Name = "txtBrojcana";
            this.txtBrojcana.Size = new System.Drawing.Size(100, 20);
            this.txtBrojcana.TabIndex = 2;
            // 
            // txtOpisna
            // 
            this.txtOpisna.Location = new System.Drawing.Point(141, 72);
            this.txtOpisna.Name = "txtOpisna";
            this.txtOpisna.Size = new System.Drawing.Size(100, 20);
            this.txtOpisna.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Maroon;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(71, 111);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 39);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // CtrlDodajOcenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtOpisna);
            this.Controls.Add(this.txtBrojcana);
            this.Controls.Add(this.rbOpisna);
            this.Controls.Add(this.rbBrojcana);
            this.Name = "CtrlDodajOcenu";
            this.Size = new System.Drawing.Size(241, 163);
            this.Load += new System.EventHandler(this.CtrlDodajOcenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBrojcana;
        private System.Windows.Forms.RadioButton rbOpisna;
        private System.Windows.Forms.TextBox txtBrojcana;
        private System.Windows.Forms.TextBox txtOpisna;
        private System.Windows.Forms.Button btnDodaj;
    }
}
