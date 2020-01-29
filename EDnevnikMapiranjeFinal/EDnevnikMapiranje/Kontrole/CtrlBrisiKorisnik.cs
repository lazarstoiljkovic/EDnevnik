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
    public partial class CtrlBrisiKorisnik : UserControl
    {
        public CtrlBrisiKorisnik()
        {
            InitializeComponent();
        }

        private void CtrlBrisiKorisnik_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Korisnik> korisnici = s.QueryOver<Korisnik>().List<Korisnik>();

                foreach (Korisnik k in korisnici)
                {
                    lbKorisnici.Items.Add(k.IdKorisnika+" "+k.Ime+" "+k.Prezime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrisiKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbKorisnici.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte korisnika koga zelite da obrisete!");
                    return;
                }

                int pos = ob.ToString().IndexOf(" ");
                int idKorisnik = int.Parse(ob.ToString().Substring(0, pos));
                Korisnik korisnik = s.Get<Korisnik>(idKorisnik);

                s.Delete(korisnik);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisan korisnik!");
                lbKorisnici.Items.Clear();
                this.CtrlBrisiKorisnik_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
