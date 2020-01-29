using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public abstract class Predmet
    {
        public virtual int IdPredmeta { get; protected set; }
        public virtual int BrCasovaNedeljno { get; set; }
        public virtual int MinBrojUcenika { get; set; }
        public virtual String Naziv { get; set; }
        public virtual String Opis { get; set; }
        public virtual String Razred { get; set; }
        public virtual String TipPredmeta { get; set; }
        public virtual String Lab { get; set; }
        public virtual String Blok { get; set; }
        public virtual IList<Predaje> PredajeNastavnik { get; set; }
        public virtual IList<NijeUcenik> ListaNastavnika { get; set; }
        public virtual IList<Ucenik> ListaUcenikaPredmet { get; set; }
        public virtual IList<Ocena> ListaOcenaPredmet { get; set; }
        public virtual IList<Odeljenje> ListaOdeljenjaPredmet { get; set; }
        public virtual IList<NijeUcenik> ListaNastavnikaDrziPredmet { get; set; }
        public virtual IList<ImaOcenu> ListaUcenikOcene { get; set; }
        public virtual IList<DrziPredmetOdeljenju> ListaNastavnikOdeljenje { get; set;}
        

        public Predmet()
        {
            ListaNastavnika = new List<NijeUcenik>();
            PredajeNastavnik = new List<Predaje>();
            ListaUcenikaPredmet = new List<Ucenik>();
            ListaOcenaPredmet = new List<Ocena>();
            ListaOdeljenjaPredmet = new List<Odeljenje>();
            ListaNastavnikaDrziPredmet = new List<NijeUcenik>();
            ListaUcenikOcene = new List<ImaOcenu>();
            ListaNastavnikOdeljenje = new List<DrziPredmetOdeljenju>();
        }
    }
}
