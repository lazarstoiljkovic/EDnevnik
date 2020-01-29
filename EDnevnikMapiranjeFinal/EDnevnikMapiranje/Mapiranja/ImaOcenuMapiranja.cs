using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class ImaOcenuMapiranja:ClassMap<ImaOcenu>
    {
        public ImaOcenuMapiranja()
        {
            Table("IMA_OCENU");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("MOJA_SEKVENCA_IMAOCENU");

            References(x => x.Predmet).Column("PREDMET_ID");
            References(x => x.Ocena).Column("OCENA_ID");
            References(x => x.Ucenik).Column("UCENIK_ID");
        }
    }
}
