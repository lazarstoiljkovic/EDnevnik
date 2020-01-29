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
    public partial class CtrlBrisiNijeUcenik : UserControl
    {
        public CtrlBrisiNijeUcenik()
        {
            InitializeComponent();
        }

        private void CtrlBrisiNijeUcenik_Load(object sender, EventArgs e)  //brisemo bilo korisnika koji nije ucenik -nastavnik,roditelj,administrator
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<NijeUcenik> nijeucenik = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                foreach (NijeUcenik nu in nijeucenik)
                {
                    lbNijeUcenik.Items.Add(nu.IdKorisnika+" "+nu.Ime+" "+nu.Prezime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiNijeUcenik_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbNijeUcenik.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte nijeUcenik koga zelite da obrisete!");
                    return;
                }

                int pos = ob.ToString().IndexOf(" ");
                int idNijeUcenik = int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik nijeUcenik = s.Get<NijeUcenik>(idNijeUcenik);

                s.Delete(nijeUcenik);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano nijeUcenik!");
                lbNijeUcenik.Items.Clear();
                this.CtrlBrisiNijeUcenik_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
