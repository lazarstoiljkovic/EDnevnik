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
    public partial class CtrlAzurirajKorisnika : UserControl
    {
        public CtrlAzurirajKorisnika()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajKorisnika_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Korisnik> korisnici = s.QueryOver<Korisnik>().List<Korisnik>();

                foreach (Korisnik k in korisnici)
                {
                    lbKorisnici.Items.Add(k.IdKorisnika + " " + k.Ime + " " + k.Prezime);
                
                }

                

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbKorisnici.SelectedItem;
                int pos = ob.ToString().IndexOf(" ");
                int idKorisnik = int.Parse(ob.ToString().Substring(0, pos));
                Korisnik korisnik = s.Load<Korisnik>(idKorisnik);

                txtJmgb.Text = korisnik.JMBG.ToString();
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
            
                txtEmail.Text = korisnik.Email;
             
                txtBrojTelefona.Text = korisnik.BrojTelefona.ToString();
                dtpDatumRodjenja.Value = korisnik.DatumRodjenja;
                if (korisnik.Pol.Equals("M"))
                {
                    rbMusko.Checked = true;
                }
                else
                {
                    rbZensko.Checked = true;
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbKorisnici.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Morate selektovati jednog korisnika");
                    return;
                }
                int pos = ob.ToString().IndexOf(" ");
                int idKorisnik = int.Parse(ob.ToString().Substring(0, pos));
                Korisnik korisnik = s.Load<Korisnik>(idKorisnik);
                korisnik.JMBG = int.Parse(txtJmgb.Text);
                korisnik.Ime = txtIme.Text;
                korisnik.Prezime = txtPrezime.Text;
               
                korisnik.Email = txtEmail.Text;
            
                korisnik.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                korisnik.DatumRodjenja = dtpDatumRodjenja.Value.Date;

                if (rbMusko.Checked)
                {
                    korisnik.Pol = "M";
                }
                else
                {
                    korisnik.Pol = "Z";
                }

                s.Update(korisnik);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno azuriran korisnik!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
