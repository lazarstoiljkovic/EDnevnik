using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class Ucenik:Korisnik
    {
        public virtual int BrOpravdanih { get; set; }
        public virtual int BrNeopravdanih { get; set; }
        public virtual int OcenaVladanje { get; set; }
        public virtual Odeljenje OdeljenjeID { get; set; }
        public virtual NijeUcenik RoditeljID { get; set; }
        public virtual IList<Ocena> ListaOcenaUcenikIma { get; set; }
        public virtual IList<Predmet> ListaPredmateUcenikSlusa { get; set; }
        public virtual IList<ImaOcenu> ListaPredmetOcena { get; set; }

        public Ucenik()
        {
            ListaOcenaUcenikIma = new List<Ocena>();
            ListaPredmateUcenikSlusa = new List<Predmet>();
            ListaPredmetOcena = new List<ImaOcenu>();
        }

    }
}
