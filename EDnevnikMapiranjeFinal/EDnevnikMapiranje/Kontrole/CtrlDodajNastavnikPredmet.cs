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
    public partial class CtrlDodajNastavnikPredmet : UserControl
    {
        public CtrlDodajNastavnikPredmet()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object o1 = Nastavnici.SelectedItem;
                Object o2 = Predmeti.SelectedItem;

                if (o1 == null || o2 == null)
                {
                    MessageBox.Show("Morate selektovati i nastavnika i predmet");
                    return;
                }

                String st1 = o1.ToString();
                String st2 = o2.ToString();
              

                Predaje predaje = new Predaje();
                PredajeID predajeID = new PredajeID();
                int pos1 = o1.ToString().IndexOf(" ");
                int pos2 = o2.ToString().IndexOf(" ");
                int idNastavnik = int.Parse(st1.Substring(0, pos1));
                int idPredmet = int.Parse(st2.Substring(0, pos2));

                NijeUcenik nu = s.Load<NijeUcenik>(idNastavnik);
                Predmet p = s.Load<Predmet>(idPredmet);

                predajeID.Predmet = p;
                predajeID.Nastavnik = nu;

                predaje.ID = predajeID;
                predaje.PlanIProgram = txtPlaniProgram.Text;


                s.Save(predaje);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat podatak u tabeli Predaje !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlDodajNastavnikPredmet_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();
                IList<NijeUcenik> nastavnici = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                foreach (Predmet p in predmeti)
                {
                    Predmeti.Items.Add(p.IdPredmeta+" "+p.Naziv);
                }

                foreach (NijeUcenik n in nastavnici)
                {
                    if (n.NastavnigFlag.Equals("Da"))
                    {
                        Nastavnici.Items.Add(n.IdKorisnika+" "+n.Ime+" "+n.Prezime);
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
