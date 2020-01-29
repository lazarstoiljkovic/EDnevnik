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
    public partial class CtrlDodajOcenu : UserControl
    {
        public CtrlDodajOcenu()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                
                ISession s = DataLayer.getSession();
                Ocena o;
                if (rbBrojcana.Checked)
                {
                    o = new BrojcanaOcena();
                    o.Broj = int.Parse(txtBrojcana.Text);
                }
                else
                {
                    o = new OpisnaOcena();
                    o.Opis = txtOpisna.Text;
                }

                s.Save(o);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno dodata nova ocena !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CtrlDodajOcenu_Load(object sender, EventArgs e)
        {
            rbBrojcana.Checked = true;
            txtOpisna.Enabled = false;
        }

        private void rbBrojcana_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBrojcana.Checked)
            {
                txtBrojcana.Enabled = true;
                txtOpisna.Enabled = false;
            }
        }

        private void rbOpisna_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpisna.Checked)
            {
                txtBrojcana.Enabled = false;
                txtOpisna.Enabled = true;
            }
        }
    }
}
