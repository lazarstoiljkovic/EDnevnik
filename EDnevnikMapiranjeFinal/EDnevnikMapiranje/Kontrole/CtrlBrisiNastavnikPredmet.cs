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
    public partial class CtrlBrisiNastavnikPredmet : UserControl
    {
        public CtrlBrisiNastavnikPredmet()
        {
            InitializeComponent();
        }

        private void BrisiNastavnikPredmet_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Predaje> predaje = s.QueryOver<Predaje>().List<Predaje>();

                foreach (Predaje p in predaje)
                {
                    lbNastavnikPredmet.Items.Add(p.ID.Nastavnik.IdKorisnika+". "+p.ID.Nastavnik.Ime+" "+p.ID.Nastavnik.Prezime+"-"+p.ID.Predmet.IdPredmeta+". "+p.ID.Predmet.Naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiNastavnikPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbNastavnikPredmet.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte PredajePredmet koji zelite da obrisete!");
                    return;
                }

                int pos1 = ob.ToString().IndexOf(".");
                int pos2 = ob.ToString().IndexOf(".", pos1 + 1);
                int mid = ob.ToString().IndexOf("-");
                MessageBox.Show(pos1.ToString() + " " + pos2.ToString() + " " + mid.ToString());
                int idNastavnik = int.Parse(ob.ToString().Substring(0, pos1));
                int idPredmet = int.Parse(ob.ToString().Substring(mid+1, pos2-1-mid));
                NijeUcenik nastavnik = s.Load<NijeUcenik>(idNastavnik);
                Predmet predmet = s.Load<Predmet>(idPredmet);

                Predaje predaje = new Predaje();
                predaje.ID.Nastavnik = nastavnik;
                predaje.ID.Predmet = predmet;

                s.Delete(predaje);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano PredajePredmet!");
                lbNastavnikPredmet.Items.Clear();
                this.BrisiNastavnikPredmet_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
