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
    public partial class CtrlBrisiJeRazredni : UserControl
    {
        public CtrlBrisiJeRazredni()
        {
            InitializeComponent();
        }

        private void btnBrisiJeRazredni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbJeRazredni.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte JeRazredni koji zelite da obrisete!");
                    return;
                }

                int pos1 = ob.ToString().IndexOf(".");
                int pos2 = ob.ToString().IndexOf(".", pos1 + 1);
                int mid = ob.ToString().IndexOf("-");
                
                int idRazredni = int.Parse(ob.ToString().Substring(0, pos1));
                int idOdeljenje = int.Parse(ob.ToString().Substring(mid + 1, pos2 - 1 - mid));
                NijeUcenik razredni = s.Load<NijeUcenik>(idRazredni);
                Odeljenje odeljenje = s.Load<Odeljenje>(idOdeljenje);

                JeRazredni jeRazredni = new JeRazredni();
                jeRazredni.Id.JeRazredniOdeljenju = razredni;
                jeRazredni.Id.ImaRazrednog = odeljenje;

                s.Delete(jeRazredni);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano JeRazredni!");
                lbJeRazredni.Items.Clear();
                this.CtrlBrisiJeRazredni_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlBrisiJeRazredni_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<JeRazredni> jeRazredni = s.QueryOver<JeRazredni>().List<JeRazredni>();

                foreach (JeRazredni jR in jeRazredni)
                {
                    lbJeRazredni.Items.Add(jR.Id.JeRazredniOdeljenju.IdKorisnika + ". " + jR.Id.JeRazredniOdeljenju.Ime + " " + jR.Id.JeRazredniOdeljenju.Prezime+ "-" + jR.Id.ImaRazrednog.IdOdeljenja+ ". " + jR.Id.ImaRazrednog.Naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
