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
    public partial class CtrlAzurirajPredmet : UserControl
    {
        public CtrlAzurirajPredmet()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajPredmet_Load(object sender, EventArgs e)
        {
            label5.Enabled = false;
            txtMinBrUcenika.Enabled = false;
            cbLab.Enabled = false;
            cbBlok.Enabled = false;
            rbObavezni.Checked = true;

            try
            {
                ISession s = DataLayer.getSession();
                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();

                foreach (Predmet p in predmeti)
                {
                    lbPredmeti.Items.Add(p.IdPredmeta + " " + p.Naziv);
                }
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
                Object o = lbPredmeti.SelectedItem;
                if (o == null)
                {
                    MessageBox.Show("Morate selektovati predmet");
                    return;
                }

                int pos = o.ToString().IndexOf(" ");
                int idPredmet = int.Parse(lbPredmeti.SelectedItem.ToString().Substring(0, pos));
                Predmet predmet = s.Load<Predmet>(idPredmet);

                Predmet p ;

               
                if (rbObavezni.Checked == true)
                {
                    p = new PredmetObavezni();
                    p = predmet;
                    p.Naziv = txtNaziv.Text;
                    p.BrCasovaNedeljno = int.Parse(txtBrCasaNed.Text);
                    p.Opis = txtOpis.Text;
                    p.Razred = txtRazred.Text;
                }
                else
                {
                    p = new PredmetIzborni();

                    p = predmet;
                    p.Naziv = txtNaziv.Text;
                    p.BrCasovaNedeljno = int.Parse(txtBrCasaNed.Text);
                    p.Opis = txtOpis.Text;
                    p.Razred = txtRazred.Text;
                    p.MinBrojUcenika = int.Parse(txtMinBrUcenika.Text);
                    if (cbBlok.Checked)
                        p.Blok = "Da";
                    else
                        p.Blok = "Ne";
                    if (cbLab.Checked)
                        p.Lab = "Da";
                    else
                        p.Lab = "Ne";
                }

                s.Update(p);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste azurirali predmet!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbObavezni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbObavezni.Checked == true)
            {
                label5.Enabled = false;
                txtMinBrUcenika.Enabled = false;
                cbLab.Enabled = false;
                cbBlok.Enabled = false;
            }
        }

        private void rbIzborni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIzborni.Checked == true)
            {
                label5.Enabled = true;
                txtMinBrUcenika.Enabled = true;
                cbLab.Enabled = true;
                cbBlok.Enabled = true;
            }
        }

        private void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                int pos = lbPredmeti.SelectedItem.ToString().IndexOf(" ");
                int idPredmet = int.Parse(lbPredmeti.SelectedItem.ToString().Substring(0, pos));
                Predmet predmet = s.Get<Predmet>(idPredmet);
                txtNaziv.Text = predmet.Naziv;
                txtRazred.Text = predmet.Razred;
                txtOpis.Text = predmet.Opis;
                txtBrCasaNed.Text = predmet.BrCasovaNedeljno.ToString();
                if (predmet.GetType() == typeof(EDnevnikMapiranje.Entiteti.PredmetObavezni))
                {
                    rbObavezni.Checked = true;
                }
                else if(predmet.GetType() == typeof(EDnevnikMapiranje.Entiteti.PredmetIzborni))
                {
                    rbIzborni.Checked = true;
                    txtMinBrUcenika.Text = predmet.MinBrojUcenika.ToString();
                    if (predmet.Lab.Equals("Da"))
                        cbLab.Checked = true;
                    if (predmet.Blok.Equals("Da"))
                        cbBlok.Checked = true;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
