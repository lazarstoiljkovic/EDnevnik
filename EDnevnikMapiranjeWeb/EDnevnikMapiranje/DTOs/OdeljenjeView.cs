using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.DTOs
{
    public class OdeljenjeView
    {
        public virtual int IdOdeljenja { get; protected set; }
        public virtual String Naziv { get; set; }
        public virtual String Smer { get; set; }
        public virtual String Raspored { get; set; }

        public OdeljenjeView(Odeljenje odeljenje)
        {
            IdOdeljenja = odeljenje.IdOdeljenja;
            Naziv = odeljenje.Naziv;
            Smer = odeljenje.Smer;
            Raspored = odeljenje.Raspored;
        }

        public OdeljenjeView()
        {

        }
    }
}
