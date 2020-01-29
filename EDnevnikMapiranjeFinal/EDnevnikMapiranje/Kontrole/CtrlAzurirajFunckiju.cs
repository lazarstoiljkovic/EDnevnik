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
    public partial class CtrlAzurirajFunckiju : UserControl
    {
        public CtrlAzurirajFunckiju()
        {
            InitializeComponent();
        }

        private void BtnDodajFunckiju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object o1 = lbFunckije.SelectedItem;

                if (o1 == null)
                {
                    MessageBox.Show("Morate selektovati funckiju !");
                    return;
                }
                //MessageBox.Show(o1.ToString().IndexOf(" ").ToString());
                int pos = o1.ToString().IndexOf(" ");
                int idFunkcije = int.Parse(o1.ToString().Substring(0, pos));
                
                Funkcija f = s.Load<Funkcija>(idFunkcije);
                f.TipFunkcije = txtTipFunckije.Text;
                s.Update(f);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno azurirana funkcija !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlAzurirajFunckiju_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Funkcija> funckije = s.QueryOver<Funkcija>().List<Funkcija>();

                foreach (Funkcija f in funckije)
                {
                    lbFunckije.Items.Add(f.IdFunkcije + " "+f.TipFunkcije);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
