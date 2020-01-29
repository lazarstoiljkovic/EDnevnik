using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDnevnikMapiranje.Kontrole;

namespace EDnevnikMapiranje
{
    public partial class CtrlAdministrator : UserControl
    {
        public CtrlAdministrator()
        {
            InitializeComponent();
        }
        

        private void AzurirajKorisnika_Click(object sender, EventArgs e)
        {
            CtrlAzurirajKorisnika ctrlAzurirajKorisnika = new CtrlAzurirajKorisnika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }

        private void ImaOcenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiImaOcenu ctrl = new CtrlBrisiImaOcenu();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void AzurirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajUcenika ctrlAzurirajKorisnika = new CtrlAzurirajUcenika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }

        private void AzurirajadministratoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajAdministratora ctrlAzurirajKorisnika = new CtrlAzurirajAdministratora();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }



        private void AzurirajroditeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajRoditelja ctrlAzurirajRoditelja = new CtrlAzurirajRoditelja();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajRoditelja);
        }

        private void AzurirajnastavnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajNastavnika ctrlAzurirajKorisnika = new CtrlAzurirajNastavnika();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }

        private void AzurirajocenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajOcenu ctrlAzurirajKorisnika = new CtrlAzurirajOcenu();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }

        private void AzurirajpredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajPredmet ctrlAzurirajKorisnika = new CtrlAzurirajPredmet();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrlAzurirajKorisnika);
        }

        private void AzurirajodeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajOdeljenje ctrlAzurirajOdeljenje = new CtrlAzurirajOdeljenje();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajOdeljenje);
        }

        private void AzurirajfunkcijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlAzurirajFunckiju ctrlAzurirajFunckiju = new CtrlAzurirajFunckiju();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlAzurirajFunckiju);
        }

        private void DodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Brisi_NijeUcenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiNijeUcenik ctrlBrisiNijeUcenik = new CtrlBrisiNijeUcenik();
            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlBrisiNijeUcenik);
        }


        private void Brisi_nastavnikPredmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiNastavnikPredmet ctrl = new CtrlBrisiNastavnikPredmet();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_obavljaFunkcijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiObavljaFunkciju ctrl = new CtrlBrisiObavljaFunkciju();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_jeRazredniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiJeRazredni ctrl = new CtrlBrisiJeRazredni();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_DrziPredmetOdeljenjuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiDrziPredmetOdeljenju ctrl = new CtrlBrisiDrziPredmetOdeljenju();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_KorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiKorisnik ctrl = new CtrlBrisiKorisnik();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }


        private void Brisi_UcenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlBrisiDrziPredmetOdeljenju ctrl = new CtrlBrisiDrziPredmetOdeljenju();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_odeljenjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CtrlBrisiOdeljenje ctrl = new CtrlBrisiOdeljenje();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_funkcijuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CtrlBrisiFunkciju ctrl = new CtrlBrisiFunkciju();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_predmetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CtrlBrisiPredmet ctrl = new CtrlBrisiPredmet();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void Brisi_ocenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CtrlBrisiOcenu ctrl = new CtrlBrisiOcenu();
            panelForme.Controls.Clear();
            panelForme.Controls.Add(ctrl);
        }

        private void RasporedCasovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlRasporedCasova ctrlRasporedCasova = new CtrlRasporedCasova();

            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrlRasporedCasova);
        }

        private void DodajUcenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlDodajUcenika ctrl = new CtrlDodajUcenika();

            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrl);
        }

        private void DodajNastavnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlDodajNastavnika ctrl = new CtrlDodajNastavnika();

            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrl);
        }

        private void DodajRoditeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CtrlDodajRoditelja ctrl = new CtrlDodajRoditelja();

            panelForme.Controls.Clear();

            panelForme.Controls.Add(ctrl);
        }
    }
}



