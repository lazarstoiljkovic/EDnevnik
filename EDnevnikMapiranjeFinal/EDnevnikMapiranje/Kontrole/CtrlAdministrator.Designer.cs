namespace EDnevnikMapiranje
{
    partial class CtrlAdministrator
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
            this.panelForme = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.odaberiteOpcijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajKorisnika = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajUcenik = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajadministratoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajroditeljaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajnastavnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajocenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajpredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajodeljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajfunkcijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_nijeUcenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastavnikPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_obavljaFunkcijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_jeRazredniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_imaOcenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_KorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_UcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_odeljenjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_funkcijuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_predmetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Brisi_ocenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRoditeljaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNastavnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasporedCasovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForme
            // 
            this.panelForme.Location = new System.Drawing.Point(62, 46);
            this.panelForme.Name = "panelForme";
            this.panelForme.Size = new System.Drawing.Size(689, 458);
            this.panelForme.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaberiteOpcijuToolStripMenuItem,
            this.obrisiToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(813, 27);
            this.menuStrip2.TabIndex = 79;
            // 
            // odaberiteOpcijuToolStripMenuItem
            // 
            this.odaberiteOpcijuToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.odaberiteOpcijuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azurirajKorisnika,
            this.azurirajUcenik,
            this.azurirajadministratoraToolStripMenuItem,
            this.azurirajroditeljaToolStripMenuItem,
            this.azurirajnastavnikaToolStripMenuItem,
            this.azurirajocenuToolStripMenuItem,
            this.azurirajpredmetToolStripMenuItem,
            this.azurirajodeljenjeToolStripMenuItem,
            this.azurirajfunkcijuToolStripMenuItem});
            this.odaberiteOpcijuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odaberiteOpcijuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.odaberiteOpcijuToolStripMenuItem.Name = "odaberiteOpcijuToolStripMenuItem";
            this.odaberiteOpcijuToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.odaberiteOpcijuToolStripMenuItem.Text = "Azuriraj";
            // 
            // azurirajKorisnika
            // 
            this.azurirajKorisnika.BackColor = System.Drawing.Color.Maroon;
            this.azurirajKorisnika.ForeColor = System.Drawing.Color.White;
            this.azurirajKorisnika.Name = "azurirajKorisnika";
            this.azurirajKorisnika.Size = new System.Drawing.Size(180, 24);
            this.azurirajKorisnika.Text = "Korisnika";
            this.azurirajKorisnika.Click += new System.EventHandler(this.AzurirajKorisnika_Click);
            // 
            // azurirajUcenik
            // 
            this.azurirajUcenik.BackColor = System.Drawing.Color.Maroon;
            this.azurirajUcenik.ForeColor = System.Drawing.Color.White;
            this.azurirajUcenik.Name = "azurirajUcenik";
            this.azurirajUcenik.Size = new System.Drawing.Size(180, 24);
            this.azurirajUcenik.Text = "Ucenika";
            this.azurirajUcenik.Click += new System.EventHandler(this.AzurirajToolStripMenuItem_Click);
            // 
            // azurirajadministratoraToolStripMenuItem
            // 
            this.azurirajadministratoraToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajadministratoraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajadministratoraToolStripMenuItem.Name = "azurirajadministratoraToolStripMenuItem";
            this.azurirajadministratoraToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajadministratoraToolStripMenuItem.Text = "Administratora";
            this.azurirajadministratoraToolStripMenuItem.Click += new System.EventHandler(this.AzurirajadministratoraToolStripMenuItem_Click);
            // 
            // azurirajroditeljaToolStripMenuItem
            // 
            this.azurirajroditeljaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajroditeljaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajroditeljaToolStripMenuItem.Name = "azurirajroditeljaToolStripMenuItem";
            this.azurirajroditeljaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajroditeljaToolStripMenuItem.Text = "Roditelja";
            this.azurirajroditeljaToolStripMenuItem.Click += new System.EventHandler(this.AzurirajroditeljaToolStripMenuItem_Click);
            // 
            // azurirajnastavnikaToolStripMenuItem
            // 
            this.azurirajnastavnikaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajnastavnikaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajnastavnikaToolStripMenuItem.Name = "azurirajnastavnikaToolStripMenuItem";
            this.azurirajnastavnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajnastavnikaToolStripMenuItem.Text = "Nastavnika";
            this.azurirajnastavnikaToolStripMenuItem.Click += new System.EventHandler(this.AzurirajnastavnikaToolStripMenuItem_Click);
            // 
            // azurirajocenuToolStripMenuItem
            // 
            this.azurirajocenuToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajocenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajocenuToolStripMenuItem.Name = "azurirajocenuToolStripMenuItem";
            this.azurirajocenuToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajocenuToolStripMenuItem.Text = "Ocenu";
            this.azurirajocenuToolStripMenuItem.Click += new System.EventHandler(this.AzurirajocenuToolStripMenuItem_Click);
            // 
            // azurirajpredmetToolStripMenuItem
            // 
            this.azurirajpredmetToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajpredmetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajpredmetToolStripMenuItem.Name = "azurirajpredmetToolStripMenuItem";
            this.azurirajpredmetToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajpredmetToolStripMenuItem.Text = "Predmet";
            this.azurirajpredmetToolStripMenuItem.Click += new System.EventHandler(this.AzurirajpredmetToolStripMenuItem_Click);
            // 
            // azurirajodeljenjeToolStripMenuItem
            // 
            this.azurirajodeljenjeToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajodeljenjeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajodeljenjeToolStripMenuItem.Name = "azurirajodeljenjeToolStripMenuItem";
            this.azurirajodeljenjeToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajodeljenjeToolStripMenuItem.Text = "Odeljenje";
            this.azurirajodeljenjeToolStripMenuItem.Click += new System.EventHandler(this.AzurirajodeljenjeToolStripMenuItem_Click);
            // 
            // azurirajfunkcijuToolStripMenuItem
            // 
            this.azurirajfunkcijuToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.azurirajfunkcijuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.azurirajfunkcijuToolStripMenuItem.Name = "azurirajfunkcijuToolStripMenuItem";
            this.azurirajfunkcijuToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.azurirajfunkcijuToolStripMenuItem.Text = "Funkciju";
            this.azurirajfunkcijuToolStripMenuItem.Click += new System.EventHandler(this.AzurirajfunkcijuToolStripMenuItem_Click);
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.obrisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Brisi_nijeUcenikToolStripMenuItem,
            this.nastavnikPredmetToolStripMenuItem,
            this.Brisi_obavljaFunkcijuToolStripMenuItem,
            this.Brisi_jeRazredniToolStripMenuItem,
            this.Brisi_imaOcenuToolStripMenuItem,
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem,
            this.Brisi_KorisnikaToolStripMenuItem,
            this.Brisi_UcenikaToolStripMenuItem,
            this.Brisi_odeljenjeToolStripMenuItem1,
            this.Brisi_funkcijuToolStripMenuItem1,
            this.Brisi_predmetToolStripMenuItem1,
            this.Brisi_ocenuToolStripMenuItem1});
            this.obrisiToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.obrisiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.obrisiToolStripMenuItem.Text = "Obrisi";
            // 
            // Brisi_nijeUcenikToolStripMenuItem
            // 
            this.Brisi_nijeUcenikToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_nijeUcenikToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_nijeUcenikToolStripMenuItem.Name = "Brisi_nijeUcenikToolStripMenuItem";
            this.Brisi_nijeUcenikToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_nijeUcenikToolStripMenuItem.Text = "Nije Ucenik";
            this.Brisi_nijeUcenikToolStripMenuItem.Click += new System.EventHandler(this.Brisi_NijeUcenikToolStripMenuItem_Click);
            // 
            // nastavnikPredmetToolStripMenuItem
            // 
            this.nastavnikPredmetToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.nastavnikPredmetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nastavnikPredmetToolStripMenuItem.Name = "nastavnikPredmetToolStripMenuItem";
            this.nastavnikPredmetToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.nastavnikPredmetToolStripMenuItem.Text = "Nastavnik-Predmet";
            this.nastavnikPredmetToolStripMenuItem.Click += new System.EventHandler(this.Brisi_nastavnikPredmetToolStripMenuItem_Click);
            // 
            // Brisi_obavljaFunkcijuToolStripMenuItem
            // 
            this.Brisi_obavljaFunkcijuToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_obavljaFunkcijuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_obavljaFunkcijuToolStripMenuItem.Name = "Brisi_obavljaFunkcijuToolStripMenuItem";
            this.Brisi_obavljaFunkcijuToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_obavljaFunkcijuToolStripMenuItem.Text = "Obavlja Funkciju";
            this.Brisi_obavljaFunkcijuToolStripMenuItem.Click += new System.EventHandler(this.Brisi_obavljaFunkcijuToolStripMenuItem_Click);
            // 
            // Brisi_jeRazredniToolStripMenuItem
            // 
            this.Brisi_jeRazredniToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_jeRazredniToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_jeRazredniToolStripMenuItem.Name = "Brisi_jeRazredniToolStripMenuItem";
            this.Brisi_jeRazredniToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_jeRazredniToolStripMenuItem.Text = "Je Razredni";
            this.Brisi_jeRazredniToolStripMenuItem.Click += new System.EventHandler(this.Brisi_jeRazredniToolStripMenuItem_Click);
            // 
            // Brisi_imaOcenuToolStripMenuItem
            // 
            this.Brisi_imaOcenuToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_imaOcenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_imaOcenuToolStripMenuItem.Name = "Brisi_imaOcenuToolStripMenuItem";
            this.Brisi_imaOcenuToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_imaOcenuToolStripMenuItem.Text = "Ima Ocenu";
            this.Brisi_imaOcenuToolStripMenuItem.Click += new System.EventHandler(this.ImaOcenuToolStripMenuItem_Click);
            // 
            // Brisi_DrziPredmetOdeljenjuToolStripMenuItem
            // 
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem.Name = "Brisi_DrziPredmetOdeljenjuToolStripMenuItem";
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem.Text = "Drzi Predmet Odeljenju";
            this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem.Click += new System.EventHandler(this.Brisi_DrziPredmetOdeljenjuToolStripMenuItem_Click);
            // 
            // Brisi_KorisnikaToolStripMenuItem
            // 
            this.Brisi_KorisnikaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_KorisnikaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_KorisnikaToolStripMenuItem.Name = "Brisi_KorisnikaToolStripMenuItem";
            this.Brisi_KorisnikaToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_KorisnikaToolStripMenuItem.Text = "Korisnika";
            this.Brisi_KorisnikaToolStripMenuItem.Click += new System.EventHandler(this.Brisi_KorisnikaToolStripMenuItem_Click);
            // 
            // Brisi_UcenikaToolStripMenuItem
            // 
            this.Brisi_UcenikaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_UcenikaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Brisi_UcenikaToolStripMenuItem.Name = "Brisi_UcenikaToolStripMenuItem";
            this.Brisi_UcenikaToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.Brisi_UcenikaToolStripMenuItem.Text = "Ucenika";
            this.Brisi_UcenikaToolStripMenuItem.Click += new System.EventHandler(this.Brisi_UcenikaToolStripMenuItem_Click);
            // 
            // Brisi_odeljenjeToolStripMenuItem1
            // 
            this.Brisi_odeljenjeToolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_odeljenjeToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.Brisi_odeljenjeToolStripMenuItem1.Name = "Brisi_odeljenjeToolStripMenuItem1";
            this.Brisi_odeljenjeToolStripMenuItem1.Size = new System.Drawing.Size(234, 24);
            this.Brisi_odeljenjeToolStripMenuItem1.Text = "Odeljenje";
            this.Brisi_odeljenjeToolStripMenuItem1.Click += new System.EventHandler(this.Brisi_odeljenjeToolStripMenuItem1_Click);
            // 
            // Brisi_funkcijuToolStripMenuItem1
            // 
            this.Brisi_funkcijuToolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_funkcijuToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.Brisi_funkcijuToolStripMenuItem1.Name = "Brisi_funkcijuToolStripMenuItem1";
            this.Brisi_funkcijuToolStripMenuItem1.Size = new System.Drawing.Size(234, 24);
            this.Brisi_funkcijuToolStripMenuItem1.Text = "Funkciju";
            this.Brisi_funkcijuToolStripMenuItem1.Click += new System.EventHandler(this.Brisi_funkcijuToolStripMenuItem1_Click);
            // 
            // Brisi_predmetToolStripMenuItem1
            // 
            this.Brisi_predmetToolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_predmetToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.Brisi_predmetToolStripMenuItem1.Name = "Brisi_predmetToolStripMenuItem1";
            this.Brisi_predmetToolStripMenuItem1.Size = new System.Drawing.Size(234, 24);
            this.Brisi_predmetToolStripMenuItem1.Text = "Predmet";
            this.Brisi_predmetToolStripMenuItem1.Click += new System.EventHandler(this.Brisi_predmetToolStripMenuItem1_Click);
            // 
            // Brisi_ocenuToolStripMenuItem1
            // 
            this.Brisi_ocenuToolStripMenuItem1.BackColor = System.Drawing.Color.Maroon;
            this.Brisi_ocenuToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.Brisi_ocenuToolStripMenuItem1.Name = "Brisi_ocenuToolStripMenuItem1";
            this.Brisi_ocenuToolStripMenuItem1.Size = new System.Drawing.Size(234, 24);
            this.Brisi_ocenuToolStripMenuItem1.Text = "Ocenu";
            this.Brisi_ocenuToolStripMenuItem1.Click += new System.EventHandler(this.Brisi_ocenuToolStripMenuItem1_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.dodajToolStripMenuItem.Checked = true;
            this.dodajToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUcenikaToolStripMenuItem,
            this.dodajRoditeljaToolStripMenuItem,
            this.dodajNastavnikaToolStripMenuItem,
            this.rasporedCasovaToolStripMenuItem});
            this.dodajToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.DodajToolStripMenuItem_Click);
            // 
            // dodajUcenikaToolStripMenuItem
            // 
            this.dodajUcenikaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.dodajUcenikaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dodajUcenikaToolStripMenuItem.Name = "dodajUcenikaToolStripMenuItem";
            this.dodajUcenikaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.dodajUcenikaToolStripMenuItem.Text = "Ucenika";
            this.dodajUcenikaToolStripMenuItem.Click += new System.EventHandler(this.DodajUcenikaToolStripMenuItem_Click);
            // 
            // dodajRoditeljaToolStripMenuItem
            // 
            this.dodajRoditeljaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.dodajRoditeljaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dodajRoditeljaToolStripMenuItem.Name = "dodajRoditeljaToolStripMenuItem";
            this.dodajRoditeljaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.dodajRoditeljaToolStripMenuItem.Text = "Roditelja";
            this.dodajRoditeljaToolStripMenuItem.Click += new System.EventHandler(this.DodajRoditeljaToolStripMenuItem_Click);
            // 
            // dodajNastavnikaToolStripMenuItem
            // 
            this.dodajNastavnikaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.dodajNastavnikaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dodajNastavnikaToolStripMenuItem.Name = "dodajNastavnikaToolStripMenuItem";
            this.dodajNastavnikaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.dodajNastavnikaToolStripMenuItem.Text = "Nastavnika";
            this.dodajNastavnikaToolStripMenuItem.Click += new System.EventHandler(this.DodajNastavnikaToolStripMenuItem_Click);
            // 
            // rasporedCasovaToolStripMenuItem
            // 
            this.rasporedCasovaToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.rasporedCasovaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rasporedCasovaToolStripMenuItem.Name = "rasporedCasovaToolStripMenuItem";
            this.rasporedCasovaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.rasporedCasovaToolStripMenuItem.Text = "Raspored casova";
            this.rasporedCasovaToolStripMenuItem.Click += new System.EventHandler(this.RasporedCasovaToolStripMenuItem_Click);
            // 
            // CtrlAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForme);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CtrlAdministrator";
            this.Size = new System.Drawing.Size(813, 538);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Panel panelForme;
        private System.Windows.Forms.Button btnRaporedCasova;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem odaberiteOpcijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajKorisnika;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajUcenik;
        private System.Windows.Forms.ToolStripMenuItem azurirajadministratoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajroditeljaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajnastavnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajocenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajpredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajodeljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajfunkcijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_nijeUcenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastavnikPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_obavljaFunkcijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_jeRazredniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_imaOcenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_DrziPredmetOdeljenjuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_KorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_UcenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Brisi_odeljenjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Brisi_funkcijuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Brisi_predmetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Brisi_ocenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajUcenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRoditeljaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNastavnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasporedCasovaToolStripMenuItem;
    }
}
