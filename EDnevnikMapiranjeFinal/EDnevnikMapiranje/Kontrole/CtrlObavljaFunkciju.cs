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
    public partial class CtrlObavljaFunkciju : UserControl
    {
        public CtrlObavljaFunkciju()
        {
            InitializeComponent();
        }

        private void CtrlObavljaFunkciju_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Funkcija> funkcije = s.QueryOver<Funkcija>().List<Funkcija>();
                IList<NijeUcenik> roditelji = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                foreach (Funkcija f in funkcije)
                {
                    Funkcije.Items.Add(f.IdFunkcije+" "+f.TipFunkcije);
                }

                foreach (NijeUcenik n in roditelji)
                {
                    if (n.RoditeljFlag.Equals("Da"))
                    {
                        Roditelji.Items.Add(n.IdKorisnika + " " + n.Ime + " " + n.Prezime);
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object o1 = Funkcije.SelectedItem;
                Object o2 = Roditelji.SelectedItem;

                if (o1 == null || o2 == null)
                {
                    MessageBox.Show("Morate selektovati i nastavnika i predmet");
                    return;
                }

                String st1 = o1.ToString();
                String st2 = o2.ToString();


                ObavljaFunkciju of = new ObavljaFunkciju();
                ObavljaFunkcijuId ofId = new ObavljaFunkcijuId();
                int pos1 = o1.ToString().IndexOf(" ");
                int pos2 = o2.ToString().IndexOf(" ");
                int idRoditelj = int.Parse(st2.Substring(0, pos2));
                int idFunkcija = int.Parse(st1.Substring(0, pos1));

                NijeUcenik nu = s.Load<NijeUcenik>(idRoditelj);
                Funkcija f = s.Load<Funkcija>(idFunkcija);

                ofId.ObavljaFunkciju = nu;
                ofId.ObavljaSe = f;

                of.Id = ofId;
                of.datumOdFunkcija = dtpDatumOd.Value.Date;
                of.datumDoFunkcija = dtpDatumDo.Value.Date;


                s.Save(of);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodat podatak u tabelu ObavljaFunkciju !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    
}
