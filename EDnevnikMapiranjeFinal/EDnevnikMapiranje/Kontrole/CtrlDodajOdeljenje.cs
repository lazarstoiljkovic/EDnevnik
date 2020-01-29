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
    public partial class CtrlDodajOdeljenje : UserControl
    {
        public CtrlDodajOdeljenje()
        {
            InitializeComponent();
        }

        private void btnDodajOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNaziv.Text == null || txtNaziv.Text.Equals("")) {
                    MessageBox.Show("Naziv odeljenja ne sme biti prazan. Molimo Vas unesite naziv !");
                }
                else
                {
                    ISession s = DataLayer.getSession();
                    Odeljenje o = new Odeljenje();
                    o.Naziv = txtNaziv.Text;
                    o.Smer = txtSmer.Text;
                    o.Raspored = txtRaspored.Text;
                    s.Save(o);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodato novo odeljenje !");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
