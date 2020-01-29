using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje
{
    public partial class CtrlDodajIImaOcenu : UserControl
    {
        public CtrlDodajIImaOcenu()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object o1 = Predmeti.SelectedItem;
                Object o2 = Ucenici.SelectedItem;
                Object o3 = Ocene.SelectedItem;

                if (o1==null || o2==null || o3==null)
                {
                    MessageBox.Show("Morate selektovati i ucenika i predmet i ocenu");
                    return;
                }
                int pos1 = o1.ToString().IndexOf(" ");
                int pos2 = o2.ToString().IndexOf(" ");
                int pos3 = o3.ToString().IndexOf(" ");
                int idUcenika = int.Parse(o2.ToString().Substring(0, pos2));
                int idOcene = int.Parse(o3.ToString().Substring(0, pos3));
                int idPredmet = int.Parse(o1.ToString().Substring(0, pos1));

                Ucenik ucenik = s.Load<Ucenik>(idUcenika);
                Ocena ocena = s.Load<Ocena>(idOcene);
                Predmet predmet = s.Load<Predmet>(idPredmet);

                ImaOcenu imaOcenu = new ImaOcenu();
                imaOcenu.Ocena = ocena;
                imaOcenu.Predmet = predmet;
                imaOcenu.Ucenik = ucenik;

                s.Save(imaOcenu);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste dodali u tabelu ImaOcenu");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CtrlDodajIImaOcenu_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Ucenik> ucenici = s.QueryOver<Ucenik>().List<Ucenik>();
                IList<Ocena> ocene = s.QueryOver<Ocena>().List<Ocena>();
                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

                foreach (Predmet p in predmeti)
                {
                    Predmeti.Items.Add(p.IdPredmeta + " " + p.Naziv);
                }

                foreach (Ucenik u in ucenici)
                {
                    Ucenici.Items.Add(u.IdKorisnika + " " + u.Ime + " " + u.Prezime);
                }

                foreach (Ocena o in ocene)
                {
                    if (o.GetType()==typeof(BrojcanaOcena))
                    {
                        Ocene.Items.Add(o.IdOcene + " " + o.Broj);
                    }
                    else if (o.GetType()==typeof(OpisnaOcena))
                    {
                        Ocene.Items.Add(o.IdOcene + " " + o.Opis);
                    }
                }


                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
