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
    public partial class CtrlDodajUcenika : UserControl
    {
        public CtrlDodajUcenika()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtJmgb.Text == null || txtJmgb.Text == "")
                    MessageBox.Show("Molimo Vas unesite JMBG !");
                else if (txtIme.Text == null || txtIme.Text == "")
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
                    Ucenik u = new Ucenik();
                    u.JMBG = long.Parse(txtJmgb.Text);
                    u.Ime = txtIme.Text;
                    u.Prezime = txtPrezime.Text;
                    u.KorisnickoIme = txtKorisnickoIme.Text;
                    u.Email = txtEmail.Text;
                    u.Lozinka = txtLozinka.Text;
                    u.DatumRodjenja = dtpDatumRodjenja.Value.Date;
                    u.BrojTelefona = long.Parse(txtBrojTelefona.Text);
                    if (rbMusko.Checked)
                        u.Pol = "M";
                    else
                        u.Pol = "Z";
                    u.BrNeopravdanih = 0;
                    u.BrOpravdanih = 0;
                    u.OcenaVladanje = 5;
                    //Umesto ovoga da se prikaze Lista Roditelja i Lista Odeljenja, pa da ucenik odabere
                    u.RoditeljID = s.Load<NijeUcenik>(123); 
                    u.OdeljenjeID = s.Load<Odeljenje>(82); ;
                    s.Save(u);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodat novi ucenik !");
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

        private void CtrlDodajUcenika_Load(object sender, EventArgs e)
        {
            rbMusko.Checked = true;
        }
    }
}
