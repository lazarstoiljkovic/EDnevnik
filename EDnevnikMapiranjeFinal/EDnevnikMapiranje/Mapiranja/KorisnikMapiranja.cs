using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;
using FluentNHibernate.Mapping;

namespace EDnevnikMapiranje.Mapiranja
{
    public class KorisnikMapiranja : ClassMap<Korisnik>
    {

        public KorisnikMapiranja()
        {
            Table("KORISNIK");

            

            Id(x => x.IdKorisnika).Column("ID_KORISNIK").GeneratedBy.TriggerIdentity();

            Map(x => x.JMBG, "JMBG");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.KorisnickoIme, "KORISNICKO_IME");
            Map(x => x.Email, "EMAIL");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Pol, "POL");
            Map(x => x.BrojTelefona, "BROJ_TELEFONA");
            Map(x => x.Lozinka, "LOZINKA");
        }
    }
}
