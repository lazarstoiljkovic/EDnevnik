using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.DTOs
{
    public class PredmetView
    {
        public int idPredmeta { get; set; }
        public String Naziv { get; set; }
        public String TipPredmeta { get; set; }

        public PredmetView()
        {

        }
        public PredmetView(Predmet p)
        {
            idPredmeta = p.IdPredmeta;
            Naziv = p.Naziv;
            TipPredmeta = p.TipPredmeta;

        }
    }
}
