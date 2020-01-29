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
    public partial class CtrlBrisiOcenu : UserControl
    {
        public CtrlBrisiOcenu()
        {
            InitializeComponent();
        }

        private void CtrlBrisiOcenu_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Ocena> ocene = s.QueryOver<Ocena>().List<Ocena>();

                foreach (Ocena o in ocene)
                {
                    if (o.GetType() == typeof(BrojcanaOcena))
                    {
                        lbOcene.Items.Add(o.IdOcene + " " + o.Broj);
                    }
                    else
                        lbOcene.Items.Add(o.IdOcene + " " + o.Opis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiOcenu_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbOcene.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte ocenu koju zelite da obrisete!");
                    return;
                }

                int pos = ob.ToString().IndexOf(" ");
                int idOcena = int.Parse(ob.ToString().Substring(0, pos));
                Ocena ocena = s.Get<Ocena>(idOcena);

                s.Delete(ocena);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano ocena!");
                lbOcene.Items.Clear();
                this.CtrlBrisiOcenu_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
