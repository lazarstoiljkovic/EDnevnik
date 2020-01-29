using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class DrziPredmetOdeljenjuMapiranja:ClassMap<DrziPredmetOdeljenju>
    {
        public DrziPredmetOdeljenjuMapiranja()
        {
            Table("DRZI_PREDMET_ODELJENJU");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("MOJA_SEKVENCA_DPO");

            References(x => x.Nastavnik).Column("NASTAVNIK_ID");
            References(x => x.Predmet).Column("PREDMET_ID");
            References(x => x.Odeljenje).Column("ODELJENJE_ID");
            
        }
    }
}
