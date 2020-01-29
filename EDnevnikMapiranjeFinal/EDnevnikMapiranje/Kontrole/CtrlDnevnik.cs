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
    public partial class CtrlDnevnik : UserControl
    {
        IList<Ucenik> listaUcenika;
        IList<ImaOcenu> listaOcena;
        IList<Predmet> listaPredmeta;
        public CtrlDnevnik(IList<Ucenik> lista)
        {
            InitializeComponent();
         
            this.listaUcenika = lista;
            listaOcena = new List<ImaOcenu>();
            listaPredmeta = new List<Predmet>();

        }

        public CtrlDnevnik()
        {
            InitializeComponent();
        }

        public int vratiIdPredmeta(string naziv, string rzred)
        {
            try
            {
                // ISession session = DataLayer.getSession();
                //  IList<Predmet> predmeti = session.QueryOver<Predmet>().List<Predmet>();

                foreach (Predmet predmet in this.listaPredmeta)
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

        public String ListaOcena(int idPredmet, int idUcenik)
        {
            String listaOcena2 = null;

            try
            {


                //vratice nam sve za ima ocenu i proveravamo samo za odredjeni predmet i odredjenog ucenika

                foreach (ImaOcenu o in this.listaOcena)
                {
                    if (o.Predmet.IdPredmeta == idPredmet && o.Ucenik.IdKorisnika == idUcenik)
                    {

                        if (o.Ocena.Broj == 0)
                        {
                            listaOcena2 += o.Ocena.Opis + ", ";

                        }
                        else
                        {
                            listaOcena2 += o.Ocena.Broj.ToString() + ", ";
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


        

        private void CtrlDnevnik_Load_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.getSession();

                IList<ImaOcenu> imaOcenu = s.QueryOver<ImaOcenu>().List<ImaOcenu>();  //vratice nam sve za ima ocenu i proveravamo samo za odredjeni predmet i odredjenog ucenika
                IList<Predmet> predmeti = s.QueryOver<Predmet>().List<Predmet>();
                this.listaPredmeta = predmeti;
                this.listaOcena = imaOcenu;



                int i = 0;
                foreach (Ucenik ucenik in this.listaUcenika)
                {


                    int pos = ucenik.OdeljenjeID.Naziv.IndexOf("-");
                    string razredOdeljenje = ucenik.OdeljenjeID.Naziv.Substring(0, pos - 1);
                    razredOdeljenje += 'i';

                    DataGridViewRow row = (DataGridViewRow)dgvDnevnik.Rows[0].Clone();
                    row.Cells[0].Value = ucenik.Ime;
                    row.Cells[1].Value = ucenik.Prezime;
                    row.Cells[2].Value = ListaOcena(this.vratiIdPredmeta("Srpski jezik", razredOdeljenje), ucenik.IdKorisnika);
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
    }
}

