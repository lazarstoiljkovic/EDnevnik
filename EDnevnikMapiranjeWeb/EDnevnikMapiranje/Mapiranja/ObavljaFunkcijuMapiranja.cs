using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class ObavljaFunkcijuMapiranja : ClassMap<ObavljaFunkciju>
    {
        public ObavljaFunkcijuMapiranja()
        {
            Table("OBAVLJA_FUNKCIJU");

            CompositeId(x => x.Id)
                .KeyReference(x => x.ObavljaFunkciju, "RODITELJ_ID")
                .KeyReference(x => x.ObavljaSe, "FUNKCIJA_ID");

            Map(x => x.datumOdFunkcija).Column("DATUM_OD_FUNKCIJA");
            Map(x => x.datumDoFunkcija).Column("DATUM_DO_FUNKCIJA");
        }
    }
}
