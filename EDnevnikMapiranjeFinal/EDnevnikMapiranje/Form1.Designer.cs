namespace EDnevnikMapiranje
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelForme = new System.Windows.Forms.Panel();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelForme
            // 
            this.panelForme.BackColor = System.Drawing.Color.Transparent;
            this.panelForme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelForme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForme.Location = new System.Drawing.Point(114, 39);
            this.panelForme.Name = "panelForme";
            this.panelForme.Size = new System.Drawing.Size(1518, 893);
            this.panelForme.TabIndex = 13;
            this.panelForme.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForme_Paint);
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.AutoSize = true;
            this.btnOdjaviSe.BackColor = System.Drawing.Color.Transparent;
            this.btnOdjaviSe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdjaviSe.BackgroundImage")));
            this.btnOdjaviSe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdjaviSe.FlatAppearance.BorderSize = 0;
            this.btnOdjaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjaviSe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjaviSe.ForeColor = System.Drawing.Color.Transparent;
            this.btnOdjaviSe.Location = new System.Drawing.Point(1209, 1);
            this.btnOdjaviSe.Margin = new System.Windows.Forms.Padding(0);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(35, 35);
            this.btnOdjaviSe.TabIndex = 14;
            this.btnOdjaviSe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOdjaviSe.UseCompatibleTextRendering = true;
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            this.btnOdjaviSe.Click += new System.EventHandler(this.BtnOdjaviSe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(688, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "EDnevnik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1653, 944);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelForme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDnevnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelForme;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Label label1;
    }
}

