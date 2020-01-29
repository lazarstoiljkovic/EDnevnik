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
    public partial class CtrlBrisiDrziPredmetOdeljenju : UserControl
    {
        public CtrlBrisiDrziPredmetOdeljenju()
        {
            InitializeComponent();
        }

        private void btnBrisiDrziPredmetOdeljenju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbDrziPredmetOdeljenju.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte DrziPredmetOdeljenju koji zelite da obrisete!");
                    return;
                }

                int pos1 = ob.ToString().IndexOf(" ");
                int idDrziPredmetOdeljenju = int.Parse(ob.ToString().Substring(0, pos1));

                DrziPredmetOdeljenju drziPredmetOdeljenju = s.Load<DrziPredmetOdeljenju>(idDrziPredmetOdeljenju);

                s.Delete(drziPredmetOdeljenju);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano DrziPredmetOdeljenju!");
                lbDrziPredmetOdeljenju.Items.Clear();
                this.CtrlBrisiDrziPredmetOdeljenju_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlBrisiDrziPredmetOdeljenju_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<DrziPredmetOdeljenju> drziPredmetOdeljenju = s.QueryOver<DrziPredmetOdeljenju>().List<DrziPredmetOdeljenju>();

                foreach (DrziPredmetOdeljenju dpo in drziPredmetOdeljenju)
                {

                    lbDrziPredmetOdeljenju.Items.Add(dpo.Id + " " + dpo.Nastavnik.Ime + " " + dpo.Nastavnik.Prezime + " drzi predmet " + dpo.Predmet.Naziv + " odeljenju " + dpo.Odeljenje.Naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
