using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.Mapiranja
{
    class OcenaMapiranja:ClassMap<Ocena>
    {
        public OcenaMapiranja()
        {
            Table("OCENA");

            DiscriminateSubClassesOnColumn("TIP_OCENE");

            Id(x => x.IdOcene).Column("ID_OCENA").GeneratedBy.TriggerIdentity();

            Map(x => x.Opis, "OPIS");
            Map(x => x.Broj, "BROJ");

            HasManyToMany(x => x.ListaUcenikaOcena)
                .Table("IMA_OCENU")
                .ParentKeyColumn("OCENA_ID")
                .ChildKeyColumn("UCENIK_ID")
                .Cascade.All();

            HasManyToMany(x => x.ListaPredmetaOcena)
                .Table("IMA_OCENU")
                .ParentKeyColumn("OCENA_ID")
                .ChildKeyColumn("PREDMET_ID")
                .Cascade.All();
        }
    }
}
