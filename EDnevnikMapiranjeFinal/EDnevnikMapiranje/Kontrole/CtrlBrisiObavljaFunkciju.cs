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
    public partial class CtrlBrisiObavljaFunkciju : UserControl
    {
        public CtrlBrisiObavljaFunkciju()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbObavljaFunkciju.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Selektujte ObavljaFunkciju koju zelite da obrisete!");
                    return;
                }

                int pos1 = ob.ToString().IndexOf(".");
                int pos2 = ob.ToString().IndexOf(".", pos1 + 1);
                int mid = ob.ToString().IndexOf("-");
                
                int idRoditelj = int.Parse(ob.ToString().Substring(0, pos1));
                int idFunkcija = int.Parse(ob.ToString().Substring(mid + 1, pos2 - 1 - mid));
                NijeUcenik roditelj = s.Load<NijeUcenik>(idRoditelj);
                Funkcija funkcija = s.Load<Funkcija>(idFunkcija);

                ObavljaFunkciju obavljaFunkcijua = new ObavljaFunkciju();
                obavljaFunkcijua.Id.ObavljaFunkciju = roditelj;
                obavljaFunkcijua.Id.ObavljaSe = funkcija;

                s.Delete(obavljaFunkcijua);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno obrisano ObavljaFunkciju!");
                lbObavljaFunkciju.Items.Clear();
                this.CtrlBrisiObavljaFunkciju_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlBrisiObavljaFunkciju_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                IList<ObavljaFunkciju> obavljaFunkciju = s.QueryOver<ObavljaFunkciju>().List<ObavljaFunkciju>();

                foreach (ObavljaFunkciju of in obavljaFunkciju)
                {
                    lbObavljaFunkciju.Items.Add(of.Id.ObavljaFunkciju.IdKorisnika + ". " + of.Id.ObavljaFunkciju.Ime + " " + of.Id.ObavljaFunkciju.Prezime + "-" + of.Id.ObavljaSe.IdFunkcije + ". " + of.Id.ObavljaSe.TipFunkcije);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
