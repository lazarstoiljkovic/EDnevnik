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
    public partial class CtrlAzurirajUcenika : UserControl
    {

        IList<Ucenik> listaUcenika;
        int brojNeopravdanih = 0;
        int brojOpravdanih = 0;
        public CtrlAzurirajUcenika()
        {
            InitializeComponent();
            listaUcenika = null;
        }

        public CtrlAzurirajUcenika(IList<Ucenik> lista)
        {
            InitializeComponent();
            this.listaUcenika = lista;
        }

        private void CtrlAzurirajUcenika_Load(object sender, EventArgs e)
        {
            try
            {
             

                if (listaUcenika == null)
                {
                    ISession s = DataLayer.getSession();


                    IList<Ucenik> ucenici = s.QueryOver<Ucenik>().List<Ucenik>();

                    foreach (Ucenik u in ucenici)
                    {
                        lbUcenici.Items.Add(u.IdKorisnika + " " + u.Ime + " " + u.Prezime);

                    }
                    s.Close();
                }
                else
                {
                    foreach (Ucenik u in this.listaUcenika)
                    {
                        lbUcenici.Items.Add(u.IdKorisnika + " " + u.Ime + " " + u.Prezime);

                    }
                }




                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbUcenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnOpravdaj.Enabled = true;
                ISession s = DataLayer.getSession();
                Object ob = lbUcenici.SelectedItem;
                int pos = ob.ToString().IndexOf(" ");
                int idUcenik = int.Parse(ob.ToString().Substring(0, pos));
                Ucenik ucenik = s.Load<Ucenik>(idUcenik);

                txtJmgb.Text = ucenik.JMBG.ToString();
                txtIme.Text = ucenik.Ime;
                txtPrezime.Text = ucenik.Prezime;
            
                txtEmail.Text = ucenik.Email;
            
                txtBrojTelefona.Text = ucenik.BrojTelefona.ToString();
                dtpDatumRodjenja.Value = ucenik.DatumRodjenja;
                if (ucenik.Pol.Equals("M"))
                {
                    rbMusko.Checked = true;
                }
                else
                {
                    rbZensko.Checked = true;
                }

                txtBrojOpravdanih.Text = ucenik.BrOpravdanih.ToString();
                brojNeopravdanih= ucenik.BrNeopravdanih;
                txtBrojNeopravdanih.Text = ucenik.BrNeopravdanih.ToString();
                brojOpravdanih = ucenik.BrOpravdanih;
                txtOcenaVladanje.Text = ucenik.OcenaVladanje.ToString();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzurirajUcenika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbUcenici.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Morate selektovati ucenika kog azurirate");
                    return;
                }
                int pos = ob.ToString().IndexOf(" ");
                int idUcenik =int.Parse (ob.ToString().Substring(0, pos));
                Ucenik ucenik = s.Load<Ucenik>(idUcenik);

                ucenik.JMBG = int.Parse(txtJmgb.Text);
                ucenik.Ime = txtIme.Text;
                ucenik.Prezime = txtPrezime.Text;
        
                ucenik.Email = txtEmail.Text;
      
                ucenik.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                ucenik.DatumRodjenja = dtpDatumRodjenja.Value.Date;

                if (rbMusko.Checked)
                {
                    ucenik.Pol = "M";
                }
                else
                {
                    ucenik.Pol = "Z";
                }

                ucenik.BrOpravdanih = int.Parse(txtBrojOpravdanih.Text);
                ucenik.BrNeopravdanih = int.Parse(txtBrojNeopravdanih.Text);
                ucenik.OcenaVladanje = int.Parse(txtOcenaVladanje.Text);

                s.Update(ucenik);
                s.Flush();
                s.Close();

                MessageBox.Show("Ucenik uspesno azuriran!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpravdaj_Click(object sender, EventArgs e)
        {
            if (brojNeopravdanih > 0)
            {
                brojNeopravdanih--;
                brojOpravdanih++;
                txtBrojNeopravdanih.Text = brojNeopravdanih.ToString();
                txtBrojOpravdanih.Text = brojOpravdanih.ToString();
            }
        }
    }
}
