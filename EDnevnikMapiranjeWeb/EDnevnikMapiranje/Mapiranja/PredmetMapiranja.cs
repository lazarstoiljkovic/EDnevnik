using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.Mapiranja
{
    class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            DiscriminateSubClassesOnColumn("TIP_PREDMETA");

            Id(x => x.IdPredmeta).Column("ID_PREDMETA").GeneratedBy.TriggerIdentity();

            Map(x => x.Opis, "OPIS");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.BrCasovaNedeljno, "BR_CASOVA_NEDELJNO");
            Map(x => x.Blok, "BLOK");
            Map(x => x.Lab, "LAB");
            Map(x => x.MinBrojUcenika, "MIN_BR_UCENIKA");
            Map(x => x.Razred, "RAZRED");

            //Mapiranje N:M za Nastavnik predaje Predmet
            HasManyToMany(x => x.ListaNastavnika)
                .Table("PREDAJE")
                .ParentKeyColumn("PREDMET_ID")
                .ChildKeyColumn("NASTAVNIK_ID")
                .Inverse()
                .Cascade.All();
            ////Mapiranje vise predmeta drzi nastavnk
            HasMany(x => x.PredajeNastavnik)
                .KeyColumn("PREDMET_ID")
                .LazyLoad()
                .Inverse()
                .Cascade.All();

            HasManyToMany(x => x.ListaOcenaPredmet)
                .Table("IMA_OCENU")
                .ParentKeyColumn("PREDMET_ID")
                .ChildKeyColumn("OCENA_ID")
                .Cascade.All();

            HasManyToMany(x => x.ListaUcenikaPredmet)
                .Table("IMA_OCENU")
                .ParentKeyColumn("PREDMET_ID")
                .ChildKeyColumn("UCENIK_ID")
                .Cascade.All();

            HasManyToMany(x => x.ListaOdeljenjaPredmet)
                .Table("DRZI_PREDMET_ODELJENJU")
                .ParentKeyColumn("PREDMET_ID")
                .ChildKeyColumn("ODELJENJE_ID")
                .Cascade.All();
            HasManyToMany(x => x.ListaNastavnikaDrziPredmet)
                .Table("DRZI_PREDMET_ODELJENJU")
                .ParentKeyColumn("PREDMET_ID")
                .ChildKeyColumn("NASTAVNIK_ID")
                .Cascade.All();
        }
    }
}
