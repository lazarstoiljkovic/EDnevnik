using System;
using EDnevnikMapiranje.Entiteti;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.DTOs
{
    public class OcenaView
    {

        public int idOcena { get; set; }
        public int Broj { get; set; }
        public String TipOcene { get; set; }
        public String Opis { get; set; }

        public OcenaView()
        {


        }

        public OcenaView(Ocena o)
        {
            idOcena = o.IdOcene;
            Broj = o.Broj;
            TipOcene = o.TipOcene;
            Opis = o.Opis;
        }

    }
}
