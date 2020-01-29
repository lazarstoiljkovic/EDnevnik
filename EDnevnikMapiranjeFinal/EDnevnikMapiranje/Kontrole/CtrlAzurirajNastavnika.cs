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
    public partial class CtrlAzurirajNastavnika : UserControl
    {
        public CtrlAzurirajNastavnika()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajNastavnika_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<NijeUcenik> nastavnici = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                foreach (NijeUcenik n in nastavnici)
                {
                    if (n.NastavnigFlag.Equals("Da"))
                    {
                        lbNastavnici.Items.Add(n.IdKorisnika + " " + n.Ime + " " + n.Prezime);
                    }
                }



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbNastavnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbNastavnici.SelectedItem;
                int pos = ob.ToString().IndexOf(" ");
                int idNastavnik = int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik nastavnik = s.Load<NijeUcenik>(idNastavnik);

                txtJmgb.Text = nastavnik.JMBG.ToString();
                txtIme.Text = nastavnik.Ime;
                txtPrezime.Text = nastavnik.Prezime;
               
                txtEmail.Text = nastavnik.Email;
           
                txtBrojTelefona.Text = nastavnik.BrojTelefona.ToString();
                dtpDatumRodjenja.Value = nastavnik.DatumRodjenja;
                if (nastavnik.Pol.Equals("M"))
                {
                    rbMusko.Checked = true;
                }
                else
                {
                    rbZensko.Checked = true;
                }

                if (nastavnik.RazredniFlag.Equals("Da"))
                {
                    cbRazredniStaresina.Checked = true;
                }

                txtStepenStrucneSpreme.Text = nastavnik.StepenStrucneSpreme;

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzurirajNastavnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbNastavnici.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Morate selektovati jednog nastavnika");
                    return;
                }
                int pos = ob.ToString().IndexOf(" ");
                int idNastavnik = int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik nastavnik = s.Load<NijeUcenik>(idNastavnik);
                nastavnik.JMBG = int.Parse(txtJmgb.Text);
                nastavnik.Ime = txtIme.Text;
                nastavnik.Prezime = txtPrezime.Text;
              
                nastavnik.Email = txtEmail.Text;
              
                nastavnik.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                nastavnik.DatumRodjenja = dtpDatumRodjenja.Value.Date;

                if (rbMusko.Checked)
                {
                    nastavnik.Pol = "M";
                }
                else
                {
                    nastavnik.Pol = "Z";
                }

                if (cbRazredniStaresina.Checked)
                {
                    nastavnik.RazredniFlag = "Da";
                }

                nastavnik.StepenStrucneSpreme = txtStepenStrucneSpreme.Text;

                s.Update(nastavnik);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno azuriran nastavnik!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
