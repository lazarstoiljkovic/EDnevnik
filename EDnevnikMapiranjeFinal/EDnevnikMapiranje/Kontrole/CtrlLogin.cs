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
    public partial class CtrlLogin : UserControl
    {

        Form form;
        public CtrlLogin()
        {
            InitializeComponent();
        }

        public CtrlLogin(Form f)
        {
            this.form = f;
            InitializeComponent();
        }

        private void CtrlLogin_Load(object sender, EventArgs e)
        {
        }

        private void BtnPrijaviSe_Click(object sender, EventArgs e)
        {
            if(txtKorisnickoIme.Text == "" || txtKorisnickoIme.Text == null 
                || txtLozinka.Text == "" || txtLozinka.Text == null)
            {
                MessageBox.Show("Morate popuniti sva polja !");
                return;
            }
            try
            {
                ISession s = DataLayer.getSession();

                IQuery query = s.CreateQuery("from Korisnik where KorisnickoIme = ? and Lozinka = ?");
                query.SetParameter(0,txtKorisnickoIme.Text);
                query.SetParameter(1, txtLozinka.Text);

                IList<Korisnik> korisnici = query.List<Korisnik>();

                if (korisnici.Count > 0)
                {
                    ((Form1)form).LogInSuccess(korisnici[0]);
                }
                else
                {
                    MessageBox.Show("Pogresno uneti podaci !");
                    return;
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
