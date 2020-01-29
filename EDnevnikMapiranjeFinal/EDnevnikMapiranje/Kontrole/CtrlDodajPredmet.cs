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
    public partial class CtrlDodajPredmet : UserControl
    {
        public CtrlDodajPredmet()
        {
            InitializeComponent();
        }

        private void CtrlDodajPredmet_Load(object sender, EventArgs e)
        {
            label5.Enabled = false;
            txtMinBrUcenika.Enabled = false;
            cbLab.Enabled = false;
            cbBlok.Enabled = false;
            rbObavezni.Checked = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNaziv.Text == null || txtNaziv.Text.Equals(""))
                {
                    MessageBox.Show("Naziv predmeta ne sme biti prazan. Molimo Vas unesite naziv !");
                }
                else
                {
                    ISession s = DataLayer.getSession();
                    Predmet p ;
                    if (rbObavezni.Checked == true)
                    {
                        p = new PredmetObavezni();
                        p.Naziv = txtNaziv.Text;
                        p.BrCasovaNedeljno = int.Parse(txtBrCasaNed.Text);
                        p.Opis = txtOpis.Text;
                        p.Razred = txtRazred.Text;
                    }
                    else
                    {
                        p = new PredmetIzborni();
                        p.Naziv = txtNaziv.Text;
                        p.BrCasovaNedeljno = int.Parse(txtBrCasaNed.Text);
                        p.Opis = txtOpis.Text;
                        p.Razred = txtRazred.Text;
                        p.MinBrojUcenika = int.Parse(txtMinBrUcenika.Text);
                        if (cbBlok.Checked)
                            p.Blok = "Da";
                        else
                            p.Blok = "Ne";
                        if(cbLab.Checked)
                            p.Lab = "Da";
                        else
                            p.Lab = "Ne";
                    }

                    s.Save(p);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodat novi predmet !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
