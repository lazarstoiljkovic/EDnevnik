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
    public partial class CtrlBrisiPredmet : UserControl
    {
        public CtrlBrisiPredmet()
        {
            InitializeComponent();
        }

        private void CtrlBrisiPredmet_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

                foreach (Predmet p in predmeti)
                {
                    lbPredmeti.Items.Add(p.IdPredmeta+" "+p.Naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiPredmeti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbPredmeti.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte predmet koji zelite da obrisete!");
                    return;
                }

                int pos = ob.ToString().IndexOf(" ");
                int idPredmet = int.Parse(ob.ToString().Substring(0, pos));
                Predmet predmet = s.Get<Predmet>(idPredmet);

                s.Delete(predmet);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano predmet!");
                lbPredmeti.Items.Clear();
                this.CtrlBrisiPredmet_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
