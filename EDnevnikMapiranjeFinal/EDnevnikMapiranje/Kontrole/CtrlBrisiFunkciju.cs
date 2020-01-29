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
    public partial class CtrlBrisiFunkciju : UserControl
    {
        public CtrlBrisiFunkciju()
        {
            InitializeComponent();
        }

        private void BtnBrisiFunkciju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbFunkcije.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte funckiju koju zelite da obrisete!");
                    return;
                }

                int pos = ob.ToString().IndexOf(" ");
                int idFunkcije = int.Parse(ob.ToString().Substring(0, pos));
                Funkcija funkcija = s.Get<Funkcija>(idFunkcije);

                s.Delete(funkcija);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisana funkcija!");
                lbFunkcije.Items.Clear();
                this.CtrlBrisiFunkciju_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlBrisiFunkciju_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<Funkcija> funkcije = s.QueryOver<Funkcija>().List<Funkcija>();

                foreach (Funkcija f in funkcije)
                {
                    lbFunkcije.Items.Add(f.IdFunkcije + " " + f.TipFunkcije);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
