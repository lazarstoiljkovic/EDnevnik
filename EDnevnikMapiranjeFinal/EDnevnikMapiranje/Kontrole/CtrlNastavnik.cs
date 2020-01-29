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

namespace EDnevnikMapiranje
{
    public partial class CtrlNastavnik : UserControl
    {
        Panel panel;
        NijeUcenik nastavnik;
        public CtrlNastavnik()
        {
            InitializeComponent();
        }

        public CtrlNastavnik(NijeUcenik nije,Panel panel)
        {
            InitializeComponent();
            this.nastavnik = nije;
            lblRazredni.Visible = false;
            this.panel = panel;
        }

        private void CtrlNastavnik_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = nastavnik.Ime + " " + nastavnik.Prezime;
            lblStepenSS.Text = "Stepen Strucne Spreme : " + nastavnik.StepenStrucneSpreme;

            try
            {
                ISession s = DataLayer.getSession();

                NijeUcenik nastavnik2= s.Load<NijeUcenik>(nastavnik.IdKorisnika);
                nastavnik = nastavnik2;
                if (nastavnik2.RazredniFlag == "Da")
                {
                    //TODO sve sto treba razrednom

                    //foreach(Predaje p in nastavnik.PredajePredmet)
                    //{
                    //    lbPredmetOdeljenjePlan.Items.Add("Predmet : "+p.ID.Predmet.Naziv+
                    //        " Plan I Program : "+p.PlanIProgram);
                    //}


                    if (nastavnik2.RazredniOdeljenjima != null)
                    {
                        lblRazredni.Text = "Staresina Odeljenju : " + ((JeRazredni)nastavnik2.RazredniOdeljenjima[0]).Id.ImaRazrednog.Naziv +
                            " Datum : " + ((JeRazredni)nastavnik2.RazredniOdeljenjima[0]).datumOdStaresina + " - " +
                            ((JeRazredni)nastavnik2.RazredniOdeljenjima[0]).datumDoStaresina;
                        lblRazredni.Visible = true;
                    }

                    foreach (DrziPredmetOdeljenju drzi in nastavnik2.ListaPredmetOdeljenja)
                    {
                        cmbPredmeti.Items.Add(drzi.Predmet.Naziv);
                        //lbPredmetOdeljenjePlan.Items.Add("Predmet : " + drzi.Predmet.Naziv +
                        //  " Odeljenje : " + drzi.Odeljenje.Naziv);
                    }

                    for (int i = 0; i < nastavnik2.ListaPredmeta.Count; i++)
                    {
                        cmbPredmeti.Items.Add(nastavnik2.ListaPredmeta[i].Naziv + "-" + nastavnik2.ListaPredmeta[i].Razred);
                    }

                    foreach (Odeljenje o in nastavnik2.ListaOdeljenjaNastavnik)
                    {
                        cmbOdeljenja.Items.Add(o.Naziv);
                        //lbPredmetOdeljenjePlan.Items.Add(" Odeljenje : " + o.Naziv);
                    }






                }
                else if (nastavnik2.PredmetniNastavnikFlag == "Da")
                {
                    //TODO sve za nastavnika

                    //foreach (Predaje p in nastavnik.PredajePredmet)
                    //{
                    //    lbPredmetOdeljenjePlan.Items.Add("Predmet : " + p.ID.Predmet.Naziv +
                    //        "Plan I Program : " + p.PlanIProgram);
                    //}


                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        

        }

        private void lbPredmetOdeljenjePlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            
            try
            {
                ISession session = DataLayer.getSession();
                Odeljenje o = null;
                Predmet p = null;

                if (cmbPredmeti.Text == "")
                {
                    MessageBox.Show("Morate uneti Predmet");

                }
                else if (cmbOdeljenja.Text == "")
                {
                    MessageBox.Show("Morate uneti Odeljenje");
                }
                else
                {
                    int pos = cmbPredmeti.Text.IndexOf("-");
                    string predmetNaziv = cmbPredmeti.Text.Substring(0, pos);
                    string predmetRazred = cmbPredmeti.Text.Substring(pos + 1);

                    int idPredmet = 0;

                    foreach (Predmet predmet in nastavnik.ListaPredmeta)
                    {
                        if (predmet.Naziv.Equals(predmetNaziv) && predmet.Razred.Equals(predmetRazred))
                        {
                            idPredmet = predmet.IdPredmeta;
                        }
                    }

                    p = session.Load<Predmet>(idPredmet);

                    string odeljenjeBaziv = cmbOdeljenja.Text;

                    int idOdeljenje = 0;

                    foreach (Odeljenje odeljenje in nastavnik.ListaOdeljenjaNastavnik)
                    {
                        if (odeljenje.Naziv.Equals(odeljenjeBaziv))
                            idOdeljenje = odeljenje.IdOdeljenja;

                    }

                    o = session.Load<Odeljenje>(idOdeljenje);

                    CtrlNastavnikInfo ctrlNastavnikInfo = new CtrlNastavnikInfo(p, o, this.nastavnik, this.panel);
                    this.panel.Controls.Clear();
                    this.panel.Controls.Add(ctrlNastavnikInfo);

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
            
        }

        private void btnDodajPlanIProgram_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();
                int pos = cmbPredmeti.Text.IndexOf("-");


                string predmetNaziv = cmbPredmeti.Text.Substring(0, pos);
                string predmetRazred = cmbPredmeti.Text.Substring(pos + 1);

                Predmet p=null;

                foreach (Predmet predmet in nastavnik.ListaPredmeta)
                {
                    if (predmet.Naziv.Equals(predmetNaziv) && predmet.Razred.Equals(predmetRazred))
                    {
                        p = predmet;
                    }
                }

                IList<Predaje> predaj = session.QueryOver<Predaje>().List<Predaje>();
                Predaje predaje = null;

                foreach (Predaje pr in predaj)
                {
                    if (pr.ID.Predmet.IdPredmeta == p.IdPredmeta && pr.ID.Nastavnik.IdKorisnika == this.nastavnik.IdKorisnika)
                    {
                        predaje = pr;
                    }
                }

                predaje.PlanIProgram = txtPlanIprogram.Text;

                session.Close();

                ISession session1 = DataLayer.getSession();

                MessageBox.Show("Uspesno ste dodali plan i program");

                session1.Update(predaje);
                session1.Flush();
                session1.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtPlanIprogram.Text = "";
                ISession session = DataLayer.getSession();
                int pos = cmbPredmeti.Text.IndexOf("-");


                string predmetNaziv = cmbPredmeti.Text.Substring(0, pos);
                string predmetRazred = cmbPredmeti.Text.Substring(pos + 1);

                Predmet p = null;

                foreach (Predmet predmet in nastavnik.ListaPredmeta)
                {
                    if (predmet.Naziv.Equals(predmetNaziv) && predmet.Razred.Equals(predmetRazred))
                    {
                        p = predmet;
                    }
                }

                IList<Predaje> predaj = session.QueryOver<Predaje>().List<Predaje>();
                Predaje predaje = null;

                foreach (Predaje pr in predaj)
                {
                    if (pr.ID.Predmet.IdPredmeta == p.IdPredmeta && pr.ID.Nastavnik.IdKorisnika == this.nastavnik.IdKorisnika)
                    {
                        predaje = pr;
                    }
                }

                if (predaje.PlanIProgram != null)
                {
                    txtPlanIprogram.Text = predaje.PlanIProgram;
                }

                session.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRazredniStaresina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();
                Odeljenje odeljenje = session.Load < Odeljenje> (this.nastavnik.RazredniOdeljenjima[0].Id.ImaRazrednog.IdOdeljenja);
                NijeUcenik razredni = session.Load<NijeUcenik>(this.nastavnik.IdKorisnika);

                CtrlRazredniStaresina ctrlRazredniStaresina = new CtrlRazredniStaresina(odeljenje, razredni, this.panel);
                this.panel.Controls.Clear();
                this.panel.Controls.Add(ctrlRazredniStaresina);

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
