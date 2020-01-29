using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class JeRazredniMapiranja : ClassMap<JeRazredni>
    {
        public JeRazredniMapiranja()
        {
            Table("JE_RAZREDNI");

            //Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("MOJA_SEKVENCA_JERAZREDNI");

            CompositeId(x => x.Id)
                .KeyReference(x => x.ImaRazrednog, "ODELJENJE_ID")
                .KeyReference(x => x.JeRazredniOdeljenju, "RAZREDNI_STARESINA_ID");

            Map(x => x.datumOdStaresina).Column("DATUM_OD_STARESINA");
            Map(x => x.datumDoStaresina).Column("DATUM_DO_STARESINA");

            //References(x => x.Id.ImaRazrednog).Column("ODELJENJE_ID");
            //References(x => x.Id.JeRazredniOdeljenju).Column("RAZREDNI_STARESINA_ID");
        }
    }
}
