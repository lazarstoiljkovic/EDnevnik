﻿namespace EDnevnikMapiranje
{
    partial class CtrlDodajOdeljenje
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
            this.btnDodajOdeljenje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSmer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaspored = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajOdeljenje
            // 
            this.btnDodajOdeljenje.BackColor = System.Drawing.Color.Maroon;
            this.btnDodajOdeljenje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDodajOdeljenje.ForeColor = System.Drawing.Color.White;
            this.btnDodajOdeljenje.Location = new System.Drawing.Point(64, 116);
            this.btnDodajOdeljenje.Name = "btnDodajOdeljenje";
            this.btnDodajOdeljenje.Size = new System.Drawing.Size(90, 32);
            this.btnDodajOdeljenje.TabIndex = 0;
            this.btnDodajOdeljenje.Text = "Dodaj";
            this.btnDodajOdeljenje.UseVisualStyleBackColor = false;
            this.btnDodajOdeljenje.Click += new System.EventHandler(this.btnDodajOdeljenje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(107, 13);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtSmer
            // 
            this.txtSmer.Location = new System.Drawing.Point(107, 39);
            this.txtSmer.Name = "txtSmer";
            this.txtSmer.Size = new System.Drawing.Size(100, 20);
            this.txtSmer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smer";
            // 
            // txtRaspored
            // 
            this.txtRaspored.Location = new System.Drawing.Point(107, 65);
            this.txtRaspored.Name = "txtRaspored";
            this.txtRaspored.Size = new System.Drawing.Size(100, 20);
            this.txtRaspored.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raspored";
            // 
            // CtrlDodajOdeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRaspored);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSmer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajOdeljenje);
            this.Name = "CtrlDodajOdeljenje";
            this.Size = new System.Drawing.Size(238, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajOdeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSmer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRaspored;
        private System.Windows.Forms.Label label3;
    }
}
