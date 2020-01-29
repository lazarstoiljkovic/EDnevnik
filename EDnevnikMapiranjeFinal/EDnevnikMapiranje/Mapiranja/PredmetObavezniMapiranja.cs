using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.Mapiranja
{
    class PredmetObavezniMapiranja:SubclassMap<PredmetObavezni>
    {
        public PredmetObavezniMapiranja()
        {
            DiscriminatorValue("Obavezni");
        }
    }
}
