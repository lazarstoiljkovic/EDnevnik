using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class Funkcija
    {
        public virtual int IdFunkcije { get; protected set; }
        public virtual String TipFunkcije { get; set; }

        public virtual IList<ObavljaFunkciju> FunkcijeObavljajuRoditelji { get; set; }
        public virtual IList<NijeUcenik> Roditelji { get; set; }

        public Funkcija()
        {
            FunkcijeObavljajuRoditelji = new List<ObavljaFunkciju>();
            Roditelji = new List<NijeUcenik>();
        }
    }
}
