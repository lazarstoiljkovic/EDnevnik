using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    public class OdeljenjeMapiranja : ClassMap<EDnevnikMapiranje.Entiteti.Odeljenje>
    {
        public OdeljenjeMapiranja()
        {
            Table("ODELJENJE");

            Id(x => x.IdOdeljenja).Column("ID_ODELJENJE").GeneratedBy.TriggerIdentity();

            HasMany(x=>x.ListaUcenika)
                .KeyColumn("ODELJENJE_ID")
                .LazyLoad()
                .Cascade.All();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Smer, "SMER");
            Map(x => x.Raspored, "RASPORED");

            HasManyToMany(x => x.RazredneStaresine)
                .Table("JE_RAZREDNI")
                .ParentKeyColumn("ODELJENJE_ID")
                .ChildKeyColumn("RAZREDNI_STARESINA_ID")
                .Cascade.All();

            HasMany(x => x.ImajuRazredneStaresine).KeyColumn("ODELJENJE_ID").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.NastavnikZaPredmet)
                .Table("DRZI_PREDMET_ODELJENJU")
                .ParentKeyColumn("ODELJENJE_ID")
                .ChildKeyColumn("NASTAVNIK_ID")
                .Cascade.All();
            HasManyToMany(x => x.PredmetZaOdeljenje)
                .Table("DRZI_PREDMET_ODELJENJU")
                .ParentKeyColumn("ODELJENJE_ID")
                .ChildKeyColumn("PREDMET_ID")
                .Cascade.All();

        }
    }
}
