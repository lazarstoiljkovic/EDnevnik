using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.Mapiranja
{
    class PredajeMapiranje : ClassMap<Predaje>
    {
        public PredajeMapiranje()
        {
            Table("PREDAJE");



            CompositeId(x => x.ID)
                .KeyReference(x => x.Predmet, "PREDMET_ID")
                .KeyReference(x => x.Nastavnik, "NASTAVNIK_ID");

            Map(x => x.PlanIProgram).Column("PLAN_I_PROGRAM");
        }
    }
}
