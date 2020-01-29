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
    public partial class CtrlAzurirajAdministratora : UserControl
    {
        public CtrlAzurirajAdministratora()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajAdministratora_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<NijeUcenik> administratori = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                foreach (NijeUcenik a in administratori)
                {
                    if (a.AdministratorFlag.Equals("Da"))
                    {
                        lbAdministratori.Items.Add(a.IdKorisnika + " " + a.Ime + " " + a.Prezime);
                    }
                }



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbAdministratori_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbAdministratori.SelectedItem;
                int pos = ob.ToString().IndexOf(" ");
                int idAdministrator = int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik administrator = s.Load<NijeUcenik>(idAdministrator);

                txtJmgb.Text = administrator.JMBG.ToString();
                txtIme.Text = administrator.Ime;
                txtPrezime.Text = administrator.Prezime;
             

                txtEmail.Text = administrator.Email;
            

                txtBrojTelefona.Text = administrator.BrojTelefona.ToString();
                dtpDatumRodjenja.Value = administrator.DatumRodjenja;
                if (administrator.Pol.Equals("M"))
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

        private void btnAzurirajAdministratora_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbAdministratori.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Morate selektovati jednog korisnika");
                    return;
                }
                int pos = ob.ToString().IndexOf(" ");
                int idAdministrator = int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik administrator = s.Load<NijeUcenik>(idAdministrator);
                administrator.JMBG = int.Parse(txtJmgb.Text);
                administrator.Ime = txtIme.Text;
                administrator.Prezime = txtPrezime.Text;
  
                administrator.Email = txtEmail.Text;
  
                administrator.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                administrator.DatumRodjenja = dtpDatumRodjenja.Value.Date;

                if (rbMusko.Checked)
                {
                    administrator.Pol = "M";
                }
                else
                {
                    administrator.Pol = "Z";
                }

                s.Update(administrator);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno azuriran korisnik!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
