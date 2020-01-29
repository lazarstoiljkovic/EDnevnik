using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class Odeljenje
    {
        public virtual int IdOdeljenja { get; protected set; }

        public virtual String Naziv { get; set; }

        public virtual String Smer { get; set; }

        public virtual String Raspored { get; set; }

        public virtual IList<Ucenik> ListaUcenika { get; set; }

        public virtual IList<JeRazredni> ImajuRazredneStaresine { get; set; }
        public virtual IList<NijeUcenik> RazredneStaresine { get; set; }
        public virtual IList<Predmet> PredmetZaOdeljenje { get; set; }
        public virtual IList<NijeUcenik> NastavnikZaPredmet { get; set; }
        public virtual IList<DrziPredmetOdeljenju> ListaNastavnikPredmet { get; set; }


        public Odeljenje()
        {
            ListaUcenika = new List<Ucenik>();
            ImajuRazredneStaresine = new List<JeRazredni>();
            RazredneStaresine = new List<NijeUcenik>();
            PredmetZaOdeljenje = new List<Predmet>();
            NastavnikZaPredmet = new List<NijeUcenik>();
            ListaNastavnikPredmet = new List<DrziPredmetOdeljenju>();
        }
    }
}
