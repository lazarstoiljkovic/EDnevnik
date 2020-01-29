using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.Mapiranja
{
    class FunkcijaMapiranja:ClassMap<Funkcija>
    {
        public FunkcijaMapiranja(){

            Table("FUNKCIJA");

            Id(x => x.IdFunkcije).Column("ID_FUNKCIJA").GeneratedBy.TriggerIdentity();
            Map(x => x.TipFunkcije,"TIP_FUNKCIJA");

            HasManyToMany(x => x.Roditelji)
                .Table("OBAVLJA_FUNKCIJU")
                .ParentKeyColumn("FUNKCIJA_ID")
                .ChildKeyColumn("RODITELJ_ID")
                .Cascade.All();

            HasMany(x => x.FunkcijeObavljajuRoditelji).KeyColumn("FUNKCIJA_ID").LazyLoad().Cascade.All().Inverse();
        }
    }
}
