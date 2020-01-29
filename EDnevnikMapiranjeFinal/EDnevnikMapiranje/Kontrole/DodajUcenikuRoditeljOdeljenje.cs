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
    public partial class DodajUcenikuRoditeljOdeljenje : UserControl
    {
        IList<Ucenik> listaUcenika;
        int idUcenik;
        int idRoditelj;
        Odeljenje odeljenje;

        public DodajUcenikuRoditeljOdeljenje()
        {
            InitializeComponent();
            listaUcenika = null;
        }

        public DodajUcenikuRoditeljOdeljenje(Odeljenje odeljenje)
        {
            InitializeComponent();
            this.odeljenje = odeljenje;
        }

        private void DodajUcenikuRoditeljOdeljenje_Load(object sender, EventArgs e)
        {
            try
            {

                    ISession s = DataLayer.getSession();

                    IList<Ucenik> ucenici = s.QueryOver<Ucenik>().List<Ucenik>();

                    IList<NijeUcenik> roditelji = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                    foreach (Ucenik u in ucenici)
                    {
                        if (u.OdeljenjeID.IdOdeljenja == 82)
                        {
                            lbUcenici.Items.Add(u.IdKorisnika + " " + u.Ime + " " + u.Prezime);
                        }
                    }


                    foreach (NijeUcenik n in roditelji)
                    {
                        if (n.RoditeljFlag == "Da")
                            cmbRoditelji.Items.Add(n.IdKorisnika.ToString()+ " " + n.Ime+ " " + n.Prezime);
                    }


                    s.Close();
              
              





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CmbRoditelji_SelectedIndexChanged(object sender, EventArgs e)
        {

          




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();

                if (lbUcenici.SelectedItem != null && cmbRoditelji.SelectedItem != null)
                {
                    int pos = lbUcenici.SelectedItem.ToString().IndexOf(" ");
                    int idUcenik = int.Parse(lbUcenici.SelectedItem.ToString().Substring(0, pos));

                    int pos1 = cmbRoditelji.SelectedItem.ToString().IndexOf(" ");
                    int idRoditelj = int.Parse(cmbRoditelji.SelectedItem.ToString().Substring(0, pos1));

                    Ucenik ucenik = session.Load<Ucenik>(idUcenik);
                    NijeUcenik roditelj = session.Load<NijeUcenik>(idRoditelj);
                    Odeljenje odeljenje = session.Load<Odeljenje>(this.odeljenje.IdOdeljenja);

                    ucenik.RoditeljID = roditelj;
                    ucenik.OdeljenjeID = this.odeljenje;

                    session.Close();

                    ISession session1 = DataLayer.getSession();

                    session1.Update(ucenik);

                    session1.Flush();
                    session1.Close();
                    MessageBox.Show("Uspesno dodat ucenik u odeljenje");
                }
                else
                {
                    MessageBox.Show("Morate da selektrujete Ucenika i Roditelja");
                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
