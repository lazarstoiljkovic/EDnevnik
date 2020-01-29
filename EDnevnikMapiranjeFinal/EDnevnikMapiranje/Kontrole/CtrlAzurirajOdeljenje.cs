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
    public partial class CtrlAzurirajOdeljenje : UserControl
    {
        public CtrlAzurirajOdeljenje()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajOdeljenje_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                
                IList<Odeljenje> odeljenja = s.QueryOver<Odeljenje>().List<Odeljenje>();

                foreach (Odeljenje o in odeljenja)
                {
                    lbOdeljenje.Items.Add(o.IdOdeljenja + " " + o.Naziv);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzurirajOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object o = lbOdeljenje.SelectedItem;

                if (o == null)
                {
                    MessageBox.Show("Morate selektovati odeljenje!");
                    return;
                }

                int pos = o.ToString().IndexOf(" ");
                int idOdeljenje = int.Parse(o.ToString().Substring(0, pos));

                Odeljenje odeljenje = s.Load<Odeljenje>(idOdeljenje);

                if (txtNaziv.Text != "")
                {
                    odeljenje.Naziv = txtNaziv.Text;
                }
                if (txtRaspored.Text != "")
                {
                    odeljenje.Raspored = txtRaspored.Text;
                }
                if (txtSmer.Text != "")
                {
                    odeljenje.Smer = txtSmer.Text;
                }

                s.Save(odeljenje);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste azurirali odeljenje!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }
    }
}
