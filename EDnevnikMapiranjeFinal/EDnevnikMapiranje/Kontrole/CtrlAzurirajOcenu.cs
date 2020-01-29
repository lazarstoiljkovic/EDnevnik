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
    public partial class CtrlAzurirajOcenu : UserControl
    {
        public CtrlAzurirajOcenu()
        {
            InitializeComponent();
        }

        private void CtrlAzurirajOcenu_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<Ocena> ocene = s.QueryOver<Ocena>().List<Ocena>();

                foreach (Ocena o in ocene)
                {
                    if (o.GetType() == typeof(OpisnaOcena))
                    {
                        lbOcene.Items.Add(o.IdOcene + " " + o.Opis);
                    }
                    else if (o.GetType() == typeof(BrojcanaOcena))
                    {
                        lbOcene.Items.Add(o.IdOcene + " " + o.Broj);
                    }
                }

                rbBrojcana.Checked = true;

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajFunckiju_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.getSession();
                Object ob = lbOcene.SelectedItem;
                if (ob == null)
                {
                    MessageBox.Show("Morate selektovati ocenu");
                    return;
                }
                int pos = ob.ToString().IndexOf(" ");
                int idOcene = int.Parse(ob.ToString().Substring(0, pos));
                Ocena ocena = s.Load<Ocena>(idOcene);
                Ocena o;


                if (rbBrojcana.Checked)
                {
                    o = new BrojcanaOcena();
                    o = ocena;
                    o.Broj = int.Parse(txtBrojcana.Text);
                }
                else
                {
                    o = new OpisnaOcena();
                    o = ocena;
                    o.Opis = txtOpisna.Text;
                }

                s.Update(o);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno azurirana ocena!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbOcene_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                Object ob = lbOcene.SelectedItem;
                int pos = ob.ToString().IndexOf(" ");
                int idOcene = int.Parse(ob.ToString().Substring(0, pos));
                Ocena ocena = s.Get<Ocena>(idOcene);

                if (ocena.GetType() == typeof(BrojcanaOcena))
                {
                    rbBrojcana.Checked = true;
                    txtBrojcana.Text = ocena.Broj.ToString();
                    txtOpisna.Text = "";
                }
                else if (ocena.GetType() == typeof(OpisnaOcena))
                {
                    rbOpisna.Checked = true;
                    txtOpisna.Text = ocena.Opis;
                    txtBrojcana.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
