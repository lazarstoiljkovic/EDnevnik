using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class NijeUcenik:Korisnik
    {
        public virtual String AdministratorFlag { get; set; }
        public virtual String NastavnigFlag { get; set; }
        public virtual String RazredniFlag { get; set; }
        public virtual String PredmetniNastavnikFlag { get; set; }
        public virtual String StepenStrucneSpreme { get; set; }
        public virtual String RoditeljFlag { get; set; }
        public virtual String USavetuFlag { get; set; }
        public virtual DateTime DatumOdSavet { get; set; }
        public virtual DateTime DatumDoSavet { get; set; }
        public virtual IList<Ucenik> ListaUcenika { get; set; }

        public virtual IList<Predaje> PredajePredmet { get; set; }
        public virtual IList<Predmet> ListaPredmeta { get; set; }

        public virtual IList<JeRazredni> RazredniOdeljenjima { get; set; }
        public virtual IList<Odeljenje> Odeljenja { get; set; }

        public virtual IList<ObavljaFunkciju> RoditeljObavljaFunkciju { get; set; }
        public virtual IList<Funkcija> Funkcije { get; set; }

        public virtual IList<Odeljenje> ListaOdeljenjaNastavnik { get; set; }
        public virtual IList<Predmet> ListaPredmetaDrziOdeljenju { get; set; }

        public virtual IList<DrziPredmetOdeljenju> ListaPredmetOdeljenja { get; set; }

        public NijeUcenik()
        {
            ListaUcenika = new List<Ucenik>();
            ListaPredmeta = new List<Predmet>();
            PredajePredmet = new List<Predaje>();
            RazredniOdeljenjima = new List<JeRazredni>();
            Odeljenja = new List<Odeljenje>();
            RoditeljObavljaFunkciju = new List<ObavljaFunkciju>();
            Funkcije = new List<Funkcija>();
            ListaOdeljenjaNastavnik = new List<Odeljenje>();
            ListaPredmetaDrziOdeljenju = new List<Predmet>();
            ListaPredmetOdeljenja = new List<DrziPredmetOdeljenju>();
        }

    }
}
