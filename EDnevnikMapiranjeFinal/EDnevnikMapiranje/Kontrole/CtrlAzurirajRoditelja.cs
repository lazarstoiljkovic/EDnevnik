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
    public partial class CtrlAzurirajRoditelja : UserControl
    {
        public CtrlAzurirajRoditelja()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajRoditelja_Load(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.getSession();

                IList<NijeUcenik> administratori = s.QueryOver<NijeUcenik>().List<NijeUcenik>();

                foreach (NijeUcenik a in administratori)
                {
                    if (a.RoditeljFlag.Equals("Da"))
                    {
                        lbRoditelji.Items.Add(a.IdKorisnika + " " + a.Ime + " " + a.Prezime);
                    }
                }



                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbRoditelji_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbRoditelji.SelectedItem;
                int pos = ob.ToString().IndexOf(" ");
                int idRoditelj= int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik roditelj = s.Load<NijeUcenik>(idRoditelj);

                txtJmgb.Text = roditelj.JMBG.ToString();
                txtIme.Text = roditelj.Ime;
                txtPrezime.Text = roditelj.Prezime;
          
                txtEmail.Text = roditelj.Email;
            
                txtBrojTelefona.Text = roditelj.BrojTelefona.ToString();
                dtpDatumRodjenja.Value = roditelj.DatumRodjenja;
                if (roditelj.Pol.Equals("M"))
                {
                    rbMusko.Checked = true;
                }
                else
                {
                    rbZensko.Checked = true;
                }

                if (roditelj.USavetuFlag.Equals("Da"))
                {
                    cbUSavetu.Checked = true;
                    dtpDatumOdUSavetu.Enabled = true;
                    dtpDatumDoUSavetu.Enabled = true;
                    dtpDatumOdUSavetu.Value = roditelj.DatumOdSavet;
                    dtpDatumDoUSavetu.Value = roditelj.DatumDoSavet;
                    label9.Enabled = true;
                    label10.Enabled = true;

                }
                else
                {
                    cbUSavetu.Checked = false;
                    dtpDatumOdUSavetu.Value = DateTime.Now;
                    dtpDatumDoUSavetu.Value = DateTime.Now;
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzurirajRoditelja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbRoditelji.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Morate selektovati jednog roditelja");
                    return;
                }
                int pos = ob.ToString().IndexOf(" ");
                int idRoditelj = int.Parse(ob.ToString().Substring(0, pos));
                NijeUcenik roditelj = s.Load<NijeUcenik>(idRoditelj);
                roditelj.JMBG = int.Parse(txtJmgb.Text);
                roditelj.Ime = txtIme.Text;
                roditelj.Prezime = txtPrezime.Text;
           
                roditelj.Email = txtEmail.Text;
      
                roditelj.BrojTelefona = int.Parse(txtBrojTelefona.Text);
                roditelj.DatumRodjenja = dtpDatumRodjenja.Value.Date;

                if (rbMusko.Checked)
                {
                    roditelj.Pol = "M";
                }
                else
                {
                    roditelj.Pol = "Z";
                }

                if (cbUSavetu.Checked)
                {
                    roditelj.USavetuFlag = "Da";
                    roditelj.DatumOdSavet = dtpDatumOdUSavetu.Value.Date;
                    roditelj.DatumDoSavet = dtpDatumDoUSavetu.Value.Date;
                }

                s.Update(roditelj);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno azuriran roditelj!!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
