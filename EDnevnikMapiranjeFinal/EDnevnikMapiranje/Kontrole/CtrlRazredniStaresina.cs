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
    public partial class CtrlRazredniStaresina : UserControl
    {
        Odeljenje odeljenje;
        Panel panel;
        NijeUcenik razredni;
        IList<Predmet> predmeti;
        IList<ImaOcenu> imaOcenu;
        IList<Ucenik> listaUcenika;


        public CtrlRazredniStaresina()
        {
            InitializeComponent();
        }


        public CtrlRazredniStaresina(Odeljenje odeljenje,NijeUcenik razredni,Panel panel)
        {
            InitializeComponent();
            this.odeljenje = odeljenje;
            this.razredni = razredni;
            this.panel = panel;
            predmeti = new List<Predmet>();
            imaOcenu = new List<ImaOcenu>();
            listaUcenika = new List<Ucenik>();
        }

        public int vratiIdPredmeta(string naziv, string rzred)
        {
            try
            {
               // ISession session = DataLayer.getSession();
              //  IList<Predmet> predmeti = session.QueryOver<Predmet>().List<Predmet>();
                
                foreach (Predmet predmet in this.predmeti)
                {
                    if (predmet.Naziv.Equals(naziv) && predmet.Razred.Equals(rzred))
                        return predmet.IdPredmeta;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }


        private void CtrlRazredniStaresina_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();
                lblOpis.Text = this.odeljenje.Naziv + " " + this.razredni.Ime + " " + this.razredni.Prezime;
                IList<ImaOcenu> imaOcenu = s.QueryOver<ImaOcenu>().List<ImaOcenu>();  //vratice nam sve za ima ocenu i proveravamo samo za odredjeni predmet i odredjenog ucenika
                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();
                this.predmeti = predmeti;
                this.imaOcenu = imaOcenu;

                int pos = this.odeljenje.Naziv.IndexOf("-");
                string razredOdeljenje = this.odeljenje.Naziv.Substring(0, pos-1);
                razredOdeljenje += 'i';
                

                int i = 0;
                foreach (Ucenik ucenik in this.odeljenje.ListaUcenika)
                {
                    this.listaUcenika.Add(ucenik);
                    
                    DataGridViewRow row = (DataGridViewRow)dgvDnevnik.Rows[0].Clone();
                    row.Cells[0].Value = ucenik.Ime;
                    row.Cells[1].Value = ucenik.Prezime;
                    row.Cells[2].Value = ListaOcena(this.vratiIdPredmeta("Srpski jezik",razredOdeljenje),ucenik.IdKorisnika);
                    row.Cells[3].Value = ListaOcena(this.vratiIdPredmeta("Matematika", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[4].Value = ListaOcena(this.vratiIdPredmeta("Biologija", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[5].Value = ListaOcena(this.vratiIdPredmeta("Geografija", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[6].Value = ListaOcena(this.vratiIdPredmeta("Istorija", razredOdeljenje), ucenik.IdKorisnika);
          
                    row.Cells[7].Value = ListaOcena(this.vratiIdPredmeta("Fizicko", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[8].Value = ListaOcena(this.vratiIdPredmeta("Likovno", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[9].Value = ListaOcena(this.vratiIdPredmeta("Muzicko", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[10].Value = ListaOcena(this.vratiIdPredmeta("Engleski jezik", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[11].Value = ListaOcena(this.vratiIdPredmeta("Nemacki jezik", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[12].Value = ListaOcena(this.vratiIdPredmeta("Francuski jezik", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[13].Value = ListaOcena(this.vratiIdPredmeta("Fizika", razredOdeljenje), ucenik.IdKorisnika);
                    row.Cells[14].Value = ListaOcena(this.vratiIdPredmeta("Hemija", razredOdeljenje), ucenik.IdKorisnika);

                    dgvDnevnik.Rows.Add(row);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession session = DataLayer.getSession();
                NijeUcenik nastavnik = session.Load<NijeUcenik>(this.razredni.IdKorisnika);
                CtrlNastavnik ctrlNastavnik = new CtrlNastavnik(nastavnik, this.panel);
                this.panel.Controls.Clear();
                this.panel.Controls.Add(ctrlNastavnik);

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public String ListaOcena(int idPredmet, int idUcenik)
        {
            String listaOcena2=null;

            try
            {
                
             
                 //vratice nam sve za ima ocenu i proveravamo samo za odredjeni predmet i odredjenog ucenika

                foreach (ImaOcenu o in this.imaOcenu)
                {
                    if (o.Predmet.IdPredmeta == idPredmet && o.Ucenik.IdKorisnika == idUcenik)
                    {

                        if (o.Ocena.Broj == 0)
                        {
                            listaOcena2 += o.Ocena.Opis+", ";

                        }
                        else
                        {
                            listaOcena2 += o.Ocena.Broj.ToString()+", ";
                        }

                       
                    }
                }
             
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return listaOcena2;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            CtrlAzurirajUcenika ctrlAzurirajUcenika = new CtrlAzurirajUcenika(this.odeljenje.ListaUcenika);
            myPanel.Controls.Clear();
            myPanel.Controls.Add(ctrlAzurirajUcenika);

        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            DodajUcenikuRoditeljOdeljenje ctrl = new DodajUcenikuRoditeljOdeljenje(this.odeljenje);
            myPanel.Controls.Clear();
            myPanel.Controls.Add(ctrl);
        }
    }
}
