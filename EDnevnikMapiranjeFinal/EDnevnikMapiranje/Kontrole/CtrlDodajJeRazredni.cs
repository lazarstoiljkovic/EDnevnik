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
    public partial class CtrlDodajJeRazredni : UserControl
    {
        public CtrlDodajJeRazredni()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object o1 = lbNastavnik.SelectedItem;
                Object o2 = lbOdeljenja.SelectedItem;

                if (o1 == null || o2 == null)
                {
                    MessageBox.Show("Morate selektovati i nastavnika i odeljenje !");
                    return;
                }

                int pos1 = o1.ToString().IndexOf(" ");
                int pos2 = o2.ToString().IndexOf(" ");
                int idNastavnika= int.Parse(o1.ToString().Substring(0, pos1));
                int idOdeljenja = int.Parse(o2.ToString().Substring(0, pos2));

                NijeUcenik n = s.Load<NijeUcenik>(idNastavnika);
               
                Odeljenje o = s.Load<Odeljenje>(idOdeljenja);

                JeRazredniId jrid = new JeRazredniId();
                jrid.JeRazredniOdeljenju = n;
                jrid.ImaRazrednog = o;
                JeRazredni jr = new JeRazredni();
                jr.Id = jrid;
                jr.datumOdStaresina = dtpDatumOdRazredni.Value.Date;
                jr.datumDoStaresina = dtpDatumDoRazredni.Value.Date;

                s.Save(jr);
                s.Flush();
                s.Close();
                ISession s2 = DataLayer.getSession();
                NijeUcenik n2 = s2.Load<NijeUcenik>(idNastavnika);
                if (n2.RazredniFlag.Equals("Ne"))
                {
                    n2.RazredniFlag = "Da";
                    s2.Update(n);
                    s2.Flush();
                    s2.Close();
                }
                MessageBox.Show("Uspesno ste dodali u tabelu JeRazredni");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlDodajJeRazredni_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<NijeUcenik> nastavnici = s.QueryOver<NijeUcenik>().List<NijeUcenik>();
                IList<Odeljenje> odeljenja = s.QueryOver<Odeljenje>().List<Odeljenje>();

                foreach (NijeUcenik n in nastavnici)
                {
                    if(n.NastavnigFlag == "Da")
                    {
                        lbNastavnik.Items.Add(n.IdKorisnika + " " + n.Ime + " " + n.Prezime);

                    }
                }

                foreach (Odeljenje o in odeljenja)
                {
                    lbOdeljenja.Items.Add(o.IdOdeljenja + " " + o.Naziv);
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
