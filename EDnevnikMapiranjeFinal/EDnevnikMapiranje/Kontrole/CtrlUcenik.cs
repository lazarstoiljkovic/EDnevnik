using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDnevnikMapiranje.Entiteti;
using NHibernate;
using EDnevnikMapiranje.Kontrole;

namespace EDnevnikMapiranje
{
    public partial class CtrlUcenik : UserControl
    {
        Ucenik ucenik;
        public CtrlUcenik()
        {
            InitializeComponent();
        }
        public CtrlUcenik(Ucenik u)
        {
            this.ucenik = u;
            InitializeComponent();
        }

        private void CtrlUcenik_Load(object sender, EventArgs e)
        {
            try
            {

                lblImePrezime.Text = ucenik.Ime + " " + ucenik.Prezime;
                lblBrOpravdanih.Text = "Broj Opravdanih : " + ucenik.BrOpravdanih.ToString();
                lblBrNeopravdanih.Text = "Broj Neopravdanih : " + ucenik.BrNeopravdanih.ToString();
                lblOcenaVladanje.Text = "Ocena Iz Vladanja : " + ucenik.OcenaVladanje.ToString();
                lblRoditelj.Text = "Roditelj : " + ucenik.RoditeljID.Ime + " " + ucenik.RoditeljID.Prezime;
                lblOdeljenje.Text = "Odeljenje : " + this.ucenik.OdeljenjeID.Naziv;
                //foreach(ImaOcenu io in ucenik.ListaPredmetOcena)
                //{
                //    if (io.Ocena.GetType() == typeof(OpisnaOcena))
                //        lbPredmetOcene.Items.Add("Naziv : " + io.Predmet.Naziv + " Ocena : " + io.Ocena.Opis);
                //    else
                //        lbPredmetOcene.Items.Add("Naziv : " + io.Predmet.Naziv + " Ocena : " + io.Ocena.Broj.ToString());
                //}

                for (int i = 0; i < ucenik.ListaPredmateUcenikSlusa.Count; i++)
                {
                    if (ucenik.ListaOcenaUcenikIma[i].GetType() == typeof(OpisnaOcena))
                        lbPredmetOcene.Items.Add("Naziv : "
                            + ucenik.ListaPredmateUcenikSlusa[i].Naziv + " Ocena : " + ucenik.ListaOcenaUcenikIma[i].Opis);
                    else
                        lbPredmetOcene.Items.Add("Naziv : "
                            + ucenik.ListaPredmateUcenikSlusa[i].Naziv + " Ocena : " + ucenik.ListaOcenaUcenikIma[i].Broj.ToString());
                }

                ISession session = DataLayer.getSession();
                IList<DrziPredmetOdeljenju> dpo = session.QueryOver<DrziPredmetOdeljenju>().List<DrziPredmetOdeljenju>();

                foreach (DrziPredmetOdeljenju drzi in dpo)
                {
                    if (drzi.Odeljenje.IdOdeljenja == this.ucenik.OdeljenjeID.IdOdeljenja)
                        if (this.nadjiPredmet(drzi.Predmet.IdPredmeta) != null)
                        {
                          
                            this.ucenik.ListaPredmateUcenikSlusa.Add(drzi.Predmet);
                        }
                }


                //foreach (Predmet predmet in this.ucenik.ListaPredmateUcenikSlusa)
                //{
                //    cmbPredmeti.Items.Add(predmet.Naziv);
                //}

                txtRasporedCasova.Text = this.ucenik.OdeljenjeID.Raspored;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string nadjiPredmet(int idPredmet)
        {
            foreach (Predmet predmet in this.ucenik.ListaPredmateUcenikSlusa)
            {
                if (predmet.IdPredmeta == idPredmet)
                    return predmet.Naziv;
            }

            return null;
        }

        private void LbPredmetOcene_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
