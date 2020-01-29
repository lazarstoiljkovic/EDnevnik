using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public abstract class Ocena
    {
        public virtual int IdOcene { get; protected set; }
        public virtual int Broj { get; set; }
        public virtual String TipOcene { get; set; }
        public virtual String Opis { get; set; }
        public virtual IList<Ucenik> ListaUcenikaOcena { get; set; }
        public virtual IList<Predmet> ListaPredmetaOcena { get; set; }
        public virtual IList<ImaOcenu> ListaUcenikPredmet { get; set; }

        public Ocena()
        {
            ListaUcenikaOcena = new List<Ucenik>();
            ListaPredmetaOcena = new List<Predmet>();
            ListaUcenikPredmet = new List<ImaOcenu>();
        }
    }
}
