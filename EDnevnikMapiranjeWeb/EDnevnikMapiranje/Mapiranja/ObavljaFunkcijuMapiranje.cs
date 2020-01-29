using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class ObavljaFunkcijuMapiranje : ClassMap<ObavljaFunkciju>
    {
        public ObavljaFunkcijuMapiranje()
        {
            Table("OBAVLJA_FUNKCIJU");
            CompositeId(x => x.Id)
                .KeyReference(x => x.FunkcijaId, "FUNKCIJA_ID")
                .KeyReference(x => x.RoditeljId, "RODITELJ_ID");

            Map(x => x.datumOdFunkcija).Column("DATUM_OD_FUNKCIJA");
            Map(x => x.datumOdFunkcija).Column("DATUM_DO_FUNKCIJA");
        }
    }
}
