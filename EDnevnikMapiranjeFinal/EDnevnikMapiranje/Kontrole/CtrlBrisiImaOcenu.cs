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
    public partial class CtrlBrisiImaOcenu : UserControl
    {
        public CtrlBrisiImaOcenu()
        {
            InitializeComponent();
        }

        private void btnBrisiImaOcenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbImaOcenu.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte ImaOcenu koji zelite da obrisete!");
                    return;
                }

                int pos1 = ob.ToString().IndexOf(" ");
                int idImaOcenu = int.Parse(ob.ToString().Substring(0, pos1));

                ImaOcenu imaOcenu = s.Load<ImaOcenu>(idImaOcenu);

                s.Delete(imaOcenu);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano ImaOcenu!");
                lbImaOcenu.Items.Clear();
                this.CtrlBrisiImaOcenu_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlBrisiImaOcenu_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<ImaOcenu> imaOcenu = s.QueryOver<ImaOcenu>().List<ImaOcenu>();

                foreach (ImaOcenu iO in imaOcenu)
                {
                    if (iO.Ocena.GetType() == typeof(BrojcanaOcena))
                    {
                        lbImaOcenu.Items.Add(iO.Id + " " + iO.Ucenik.Ime + " " + iO.Ucenik.Prezime + " " + "ima ocenu: " + iO.Ocena.Broj + " iz predmeta " + iO.Predmet.Naziv);
                    }
                    else
                    {
                        lbImaOcenu.Items.Add(iO.Id + " " + iO.Ucenik.Ime + " " + iO.Ucenik.Prezime + " " + "ima ocenu: " + iO.Ocena.Opis + " iz predmeta " + iO.Predmet.Naziv);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
