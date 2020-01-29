using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    class NIjeUcenikMapiranja:SubclassMap<NijeUcenik>
    {
        public NIjeUcenikMapiranja()
        {
            Table("NIJE_UCENIK");

            KeyColumn("ID_KORISNIK");


            
            
            Map(x => x.AdministratorFlag, "ADMINISTRATORF");
            Map(x => x.NastavnigFlag, "NASTAVNIKF");
            Map(x => x.RazredniFlag, "RAZREDNI_STARESINAF");
            Map(x => x.PredmetniNastavnikFlag, "PREDMETNI_NASTAVNIKF");
            Map(x => x.StepenStrucneSpreme, "STEPEN_STRUCNE_SPREME");
            Map(x => x.USavetuFlag, "U_SAVETUF");
            Map(x => x.RoditeljFlag, "RODITELJF");
            Map(x => x.DatumDoSavet, "DATUM_DO_SAVET");
            Map(x => x.DatumOdSavet, "DATUM_OD_SAVET");

            //Mapiranje 1:N Roditelj je roditelj Ucenik
            HasMany(x => x.ListaUcenika)
                .KeyColumn("RODITELJ_ID")
                .LazyLoad()
                .Inverse()
                .Cascade.All();

            ////Mapiranje N:M za Nastavnik predaje Predmet
            HasManyToMany(x => x.ListaPredmeta)
                .Table("PREDAJE")
                .ParentKeyColumn("NASTAVNIK_ID")
                .ChildKeyColumn("PREDMET_ID")  //posle ovog je bilo .Inverse() i zbog toga nije radilo
                .Cascade.All();

            HasMany(x => x.PredajePredmet).KeyColumn("NASTAVNIK_ID").LazyLoad().Inverse().Cascade.All();


            HasManyToMany(x => x.Odeljenja)
                .Table("JE_RAZREDNI")
                .ParentKeyColumn("RAZREDNI_STARESINA_ID")
                .ChildKeyColumn("ODELJENJE_ID")
                .Cascade.All();

            HasMany(x => x.RazredniOdeljenjima).KeyColumn("RAZREDNI_STARESINA_ID").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Funkcije)
                .Table("OBAVLJA_FUNKCIJU")
                .ParentKeyColumn("RODITELJ_ID")
                .ChildKeyColumn("FUNKCIJA_ID")
                .Cascade.All();

            HasMany(x => x.RoditeljObavljaFunkciju).KeyColumn("RODITELJ_ID").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.ListaOdeljenjaNastavnik)
                .Table("DRZI_PREDMET_ODELJENJU")
                .ParentKeyColumn("NASTAVNIK_ID")
                .ChildKeyColumn("ODELJENJE_ID")
                .Cascade.All();
            HasManyToMany(x => x.ListaPredmetaDrziOdeljenju)
                .Table("DRZI_PREDMET_ODELJENJU")
                .ParentKeyColumn("NASTAVNIK_ID")
                .ChildKeyColumn("PREDMET_ID")
                .Cascade.All();



        }
    }
}
