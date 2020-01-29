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
    public partial class CtrlBrisiOdeljenje : UserControl
    {
        public CtrlBrisiOdeljenje()
        {
            InitializeComponent();
        }

        private void CtrlBrisiOdeljenje_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Odeljenje> odeljenja = s.QueryOver<Odeljenje>().List<Odeljenje>();

                foreach (Odeljenje o  in odeljenja)
                {
                    lbOdeljenja.Items.Add(o.IdOdeljenja+" "+o.Naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbOdeljenja.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte odeljenje koje zelite da obrisete!");
                    return;
                }

                int pos = ob.ToString().IndexOf(" ");
                int idOdeljenje = int.Parse(ob.ToString().Substring(0, pos));
                Odeljenje odeljenje = s.Get<Odeljenje>(idOdeljenje);

                s.Delete(odeljenje);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano odeljenje!");
                lbOdeljenja.Items.Clear();
                this.CtrlBrisiOdeljenje_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
