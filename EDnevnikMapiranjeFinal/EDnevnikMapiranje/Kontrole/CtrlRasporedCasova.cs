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

namespace EDnevnikMapiranje.Kontrole
{
    public partial class CtrlRasporedCasova : UserControl
    {
        IList<Odeljenje> listaOdeljenja;
        public CtrlRasporedCasova()
        {
            InitializeComponent();
            listaOdeljenja = new List<Odeljenje>();
        }

        private void CtrlRasporedCasova_Load(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();

                IList<Odeljenje> odeljenja = session.QueryOver<Odeljenje>().List<Odeljenje>();
                this.listaOdeljenja = odeljenja;
                foreach (Odeljenje o in odeljenja)
                {
                    cmbOdeljenja.Items.Add(o.Naziv);
                }

                session.Close();
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
                ISession session = DataLayer.getSession();

                string nazivOdeljenja = cmbOdeljenja.SelectedItem.ToString();
                int idOdeljenja = 0;

                foreach (Odeljenje odeljenje in this.listaOdeljenja)
                {
                    if (odeljenje.Naziv.Equals(nazivOdeljenja))
                        idOdeljenja = odeljenje.IdOdeljenja;
                }

                Odeljenje od = session.Load<Odeljenje>(idOdeljenja);
                od.Raspored = txtRasporedCasova.Text;
                session.Close();

                ISession s = DataLayer.getSession();

                s.Update(od);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno ste dodali novi raspored casova");
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
