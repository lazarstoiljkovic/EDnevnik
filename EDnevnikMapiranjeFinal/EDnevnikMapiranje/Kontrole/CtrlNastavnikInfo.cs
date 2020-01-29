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
    public partial class CtrlNastavnikInfo : UserControl
    {
        Odeljenje odeljenje;
        Predmet predmet;
        NijeUcenik nastavnik;
        Panel panel;
        Ucenik ucenik;
        
        public CtrlNastavnikInfo()
        {
            InitializeComponent();
        }

        public CtrlNastavnikInfo(Predmet predmet,Odeljenje odeljenje,NijeUcenik nastavnik,Panel panel)
        {
            InitializeComponent();
            this.predmet = predmet;
            this.odeljenje = odeljenje;
            this.nastavnik = nastavnik;
            this.panel = panel;
           
        }

        public CtrlNastavnikInfo(Predmet predmet, Odeljenje odeljenje)
        {
            InitializeComponent();
            this.predmet = predmet;
            this.odeljenje = odeljenje;
          

        }


        public CtrlNastavnikInfo( Odeljenje odeljenje)
        {
            InitializeComponent();
            this.odeljenje = odeljenje;
           
        }

        private void CtrlNastavnikInfo_Load(object sender, EventArgs e)
        {
            lblPredmet.Text = this.predmet.Naziv;
            lbOdeljenje.Text = this.odeljenje.Naziv;

            foreach (Ucenik ucenik in this.odeljenje.ListaUcenika)
            {
                lbUcenici.Items.Add(ucenik.IdKorisnika+" "+ucenik.Ime + " " + ucenik.Prezime);
            }


        }

        private void lbUcenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object selektovanUcenik = lbUcenici.SelectedItem;
                int pos = selektovanUcenik.ToString().IndexOf(" ");
                int id = int.Parse(selektovanUcenik.ToString().Substring(0, pos));
                int idPredmet = this.predmet.IdPredmeta;

                Ucenik ucenik = s.Load<Ucenik>(id);

                IList<ImaOcenu> imaOcenu = s.QueryOver<ImaOcenu>().List<ImaOcenu>();  //vratice nam sve za ima ocenu i proveravamo samo za odredjeni predmet i odredjenog ucenika
                List<int> ocene = new List<int>();
                List<String> opisne = new List<string>();

                foreach (ImaOcenu io in imaOcenu)
                {
                    if (io.Predmet.IdPredmeta == idPredmet && io.Ucenik.IdKorisnika == id)
                    {
                        
                        
                        if (io.Ocena.Broj==0)
                        {
                            opisne.Add(io.Ocena.Opis);
                            
                        }
                        else 
                        {
                            ocene.Add(io.Ocena.Broj);
                        }
                    }
                }
             

                Ucenik uc = null;
                foreach (Ucenik ucenik1 in this.odeljenje.ListaUcenika)
                {
                    if (ucenik1.IdKorisnika == id)
                        uc = ucenik1;
                }

                this.ucenik = uc;

                lblPrikaz.Text = uc.IdKorisnika + " " + uc.Ime + " " + uc.Prezime;
                lblBrojcaneOcene.Text = "Brojcane ocene: ";
                lblOpisneOcene.Text = "Opisne Ocene ";

                for (int j = 0; j < ocene.Count; j++)
                {
                    lblBrojcaneOcene.Text += ocene[j] + ", ";
                }

                for (int j = 0; j < opisne.Count; j++)
                {
                    lblOpisneOcene.Text += opisne[j] + ", ";
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            CtrlNastavnik ctrlNastavnik = new CtrlNastavnik(this.nastavnik, this.panel);
            this.panel.Controls.Clear();
            this.panel.Controls.Add(ctrlNastavnik);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();

                int ocena = (int)nudBrojcanaOcena.Value;
                IList<Ocena> ocene = session.QueryOver<Ocena>().List<Ocena>();
                Ocena oc = null;

                lblBrojcaneOcene.Text += ocena + ", ";

                foreach (Ocena o in ocene)
                {
                    if (o.Broj == ocena)
                        oc = o;
                }

                ImaOcenu imaOcenu = new ImaOcenu();
                imaOcenu.Ocena = oc;
                imaOcenu.Predmet = this.predmet;
                imaOcenu.Ucenik = this.ucenik;


                session.Save(imaOcenu);
          
                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpisna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();

                String ocena =cmbOpisnaOcena.Text;
                IList<Ocena> ocene = session.QueryOver<Ocena>().List<Ocena>();
                Ocena oc = null;

                lblOpisneOcene.Text += ocena + ", ";

                foreach (Ocena o in ocene)
                {
                    if (o.GetType() == typeof(OpisnaOcena))
                    {
                       // MessageBox.Show(o.GetType().ToString());
                        if (o.Opis.Equals(ocena))
                            oc = o;
                    }
                }

                ImaOcenu imaOcenu = new ImaOcenu();
                imaOcenu.Ocena = oc;
                imaOcenu.Predmet = this.predmet;
                imaOcenu.Ucenik = this.ucenik;


                session.Save(imaOcenu);

                session.Flush();
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZapisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();
                Ucenik ucenik = session.Load<Ucenik>(this.ucenik.IdKorisnika);
                ucenik.BrNeopravdanih++;

                session.Close();

             

                ISession session1 = DataLayer.getSession();

                MessageBox.Show("Upisali ste ucenika");

                session1.Update(ucenik);
                session1.Flush();
                session1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
