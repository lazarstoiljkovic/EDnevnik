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
    public partial class CtrlDodajKorisnika : UserControl
    {
        public CtrlDodajKorisnika()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtJmgb.Text == null || txtJmgb.Text == "")
                    MessageBox.Show("Molimo Vas unesite JMBG !");
                else if(txtIme.Text == null || txtIme.Text == "")
                    MessageBox.Show("Molimo Vas unesite Ime !");
                else if (txtPrezime.Text == null || txtPrezime.Text == "")
                    MessageBox.Show("Molimo Vas unesite Prezime !");
                else if (txtKorisnickoIme.Text == null || txtKorisnickoIme.Text == "")
                    MessageBox.Show("Molimo Vas unesite Korisnicko ime !");
                else if (txtEmail.Text == null || txtEmail.Text == "")
                    MessageBox.Show("Molimo Vas unesite Email !");
                else if (txtLozinka.Text == null || txtLozinka.Text == "")
                    MessageBox.Show("Molimo Vas unesite Lozinku !");
                else
                {
                    ISession s = DataLayer.getSession();
                    Korisnik k = new Korisnik();
                    k.JMBG = long.Parse(txtJmgb.Text);
                    k.Ime = txtIme.Text;
                    k.Prezime = txtPrezime.Text;
                    k.KorisnickoIme = txtKorisnickoIme.Text;
                    k.Email = txtEmail.Text;
                    k.Lozinka = txtLozinka.Text;
                    k.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                    k.BrojTelefona = long.Parse(txtBrojTelefona.Text);
                    if (rbMusko.Checked)
                        k.Pol = "M";
                    else
                        k.Pol = "Z";
                    s.Save(k);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodat novi korisnik !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtJmgb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CtrlDodajKorisnika_Load(object sender, EventArgs e)
        {
            rbMusko.Checked = true;
        }
    }
}
