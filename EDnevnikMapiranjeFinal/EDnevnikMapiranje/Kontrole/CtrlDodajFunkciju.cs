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
    public partial class CtrlDodajFunkciju : UserControl
    {
        public CtrlDodajFunkciju()
        {
            InitializeComponent();
        }

        private void btnDodajFunckiju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Funkcija f = new Funkcija();
                f.TipFunkcije = txtTipFunckije.Text;
                s.Save(f);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodata nova funkcija !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlDodajFunkciju_Load(object sender, EventArgs e)
        {

        }
    }
}
