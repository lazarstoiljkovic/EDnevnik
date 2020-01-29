using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class UcenikMapiranja:SubclassMap<Ucenik>
    {
        public UcenikMapiranja()
        {
            Table("UCENIK");

            KeyColumn("ID_KORISNIK"); 

            References(x => x.OdeljenjeID)
                .Column("ODELJENJE_ID")
                .LazyLoad();

            References(x => x.RoditeljID)
                .Column("RODITELJ_ID")
                .LazyLoad();
            

            Map(x => x.BrNeopravdanih, "BR_NEOPRAVDANIH");
            Map(x => x.BrOpravdanih, "BR_OPRAVDANIH");
            Map(x => x.OcenaVladanje, "OCENA_VLADANJE");

            HasManyToMany(x => x.ListaOcenaUcenikIma)
                .Table("IMA_OCENU")
                .ParentKeyColumn("UCENIK_ID")
                .ChildKeyColumn("OCENA_ID")
                .Inverse()
                .Cascade.All();

            HasManyToMany(x => x.ListaPredmateUcenikSlusa)
                .Table("IMA_OCENU")
                .ParentKeyColumn("UCENIK_ID")
                .ChildKeyColumn("PREDMET_ID")
                .Inverse()
                .Cascade.All();
        }
    }
}
