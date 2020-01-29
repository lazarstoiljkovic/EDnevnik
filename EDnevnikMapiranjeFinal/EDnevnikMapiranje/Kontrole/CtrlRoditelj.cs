using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDnevnikMapiranje.Entiteti;
using NHibernate;

namespace EDnevnikMapiranje
{
    public partial class CtrlRoditelj : UserControl
    {
        NijeUcenik roditelj;
        IList<Ucenik> deca;

        public CtrlRoditelj()
        {
            InitializeComponent();
        }
        public CtrlRoditelj(NijeUcenik nijeUcenik)
        {
            this.roditelj = nijeUcenik;
            InitializeComponent();
            lblFunkcija.Text = "";
        }

        private void CtrlRoditelj_Load(object sender, EventArgs e)
        {
            lblImePrezime.Text = roditelj.Ime + " " + roditelj.Prezime;
            if(roditelj.USavetuFlag == "Da")
            {
                lblSavet.Text = "Datum u savetu : " + roditelj.DatumOdSavet + " - " + roditelj.DatumDoSavet;
                if(roditelj.RoditeljObavljaFunkciju.Count > 0)
                {
                    foreach(ObavljaFunkciju of in roditelj.RoditeljObavljaFunkciju)
                    {
                        lblFunkcija.Text += "Tip Funkcije : " + of.Id.ObavljaSe.TipFunkcije +
                            " Datum : "+ of.datumOdFunkcija+" - "+ of.datumDoFunkcija + "\n";
                    }
                }

            }
            try
            {
                ISession s = DataLayer.getSession();

                IQuery query = s.CreateQuery("from Ucenik where RoditeljID.IdKorisnika = ?");
                query.SetInt32(0, roditelj.IdKorisnika);

                IList<Ucenik> Deca = query.List<Ucenik>();
                this.deca = Deca;

                if (deca.Count > 0)
                {
                    foreach(Ucenik u in Deca)
                    {

                        cmbDeca.Items.Add(u.IdKorisnika+" "+u.Ime + " " + u.Prezime);
                        
                        
                    }
                }

                CtrlDnevnik dnevnik = new CtrlDnevnik(Deca);

                panelDnevnik.Controls.Clear();
                panelDnevnik.Controls.Add(dnevnik);


                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmbDeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.getSession();

                IQuery query = s.CreateQuery("from Ucenik where RoditeljID.IdKorisnika = ?");
                query.SetInt32(0, roditelj.IdKorisnika);

                IList<Ucenik> Deca = query.List<Ucenik>();

                int pos = cmbDeca.SelectedItem.ToString().IndexOf(" ");
                int idDete = int.Parse(cmbDeca.SelectedItem.ToString().Substring(0, pos));

                foreach (Ucenik dete in Deca)
                {
                    if (idDete == dete.IdKorisnika)
                    {
                        lblime.Text = dete.Ime + " " + dete.Prezime + "\n" + "Broj opravdanih: " + dete.BrOpravdanih + "\n" + "Broja neopravdanih: " + dete.BrNeopravdanih + "\n" + "Odeljenje: "
                            + dete.OdeljenjeID.Naziv;

                    }

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
