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
    public partial class CtrlDrziPredmetOdeljenju : UserControl
    {
        public CtrlDrziPredmetOdeljenju()
        {
            InitializeComponent();
        }

        private void CtrlDrziPredmetOdeljenju_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

     

                IList<NijeUcenik> nastavnici = s.QueryOver<NijeUcenik>().List<NijeUcenik>();
                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();
                IList<Odeljenje> odeljenja = s.QueryOver<Odeljenje>().List<Odeljenje>();

                foreach (Predmet p in predmeti)
                {
                    Predmet.Items.Add(p.IdPredmeta + " " + p.Naziv);
                }

                foreach (NijeUcenik nu in nastavnici)
                {
                    if (nu.NastavnigFlag.Equals("Da"))
                    {
                        Nastavnik.Items.Add(nu.IdKorisnika + " " + nu.Ime + " " + nu.Prezime);
                    }
                    
                }

                foreach (Odeljenje o in odeljenja)
                {
                    Odeljenje.Items.Add(o.IdOdeljenja + " " + o.Naziv);                
                }



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                Object o1 = Nastavnik.SelectedItem;
                Object o2 = Predmet.SelectedItem;
                Object o3 = Odeljenje.SelectedItem;

                if (o1 == null || o2 == null || o3 == null)
                {
                    MessageBox.Show("Morate selektovati i nastavnika i predmet i odeljenje!");
                    return;

                }

                int pos1 = o1.ToString().IndexOf(" ");
                int pos2 = o2.ToString().IndexOf(" ");
                int pos3 = o3.ToString().IndexOf(" ");
                int idNastavnik = int.Parse(o1.ToString().Substring(0, pos1));
                int idPredmet = int.Parse(o2.ToString().Substring(0, pos2));
                int idOdeljenje = int.Parse(o3.ToString().Substring(0, pos3));

                NijeUcenik nu = s.Load<NijeUcenik>(idNastavnik);
                Predmet p = s.Load<Predmet>(idPredmet);
                Odeljenje o = s.Load<Odeljenje>(idOdeljenje);

                DrziPredmetOdeljenju dpo = new DrziPredmetOdeljenju();
                dpo.Nastavnik = nu;
                dpo.Odeljenje = o;
                dpo.Predmet = p;

                s.Save(dpo);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat podatak u tabelu drzi predmet odeljenju!");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
