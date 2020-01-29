using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    public class OpisnaOcenaMapiranja:SubclassMap<OpisnaOcena>
    {
        public OpisnaOcenaMapiranja()
        {
            DiscriminatorValue("Opisna");
        }
    }
}
