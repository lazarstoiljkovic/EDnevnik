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
    public partial class CtrlBrisiUcenika : UserControl
    {
        public CtrlBrisiUcenika()
        {
            InitializeComponent();
        }

        private void CtrlBrisiUcenika_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Ucenik> ucenici = s.QueryOver<Ucenik>().List<Ucenik>();

                foreach (Ucenik u in ucenici)
                {
                    lbUcenici.Items.Add(u.IdKorisnika + " " + u.Ime + " " + u.Prezime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiUcenika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbUcenici.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte ucenika kog zelite da obrisete!");
                }

                int pos = ob.ToString().IndexOf(" ");
                int idUcenik = int.Parse(ob.ToString().Substring(0, pos));
                Ucenik ucenik = s.Get<Ucenik>(idUcenik);

                s.Delete(ucenik);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisan ucenik!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LbUcenici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
