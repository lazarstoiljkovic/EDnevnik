using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class Korisnik
    {
        public virtual int IdKorisnika { get; protected set; }

        public virtual long JMBG { get; set; }

        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }

        public virtual String KorisnickoIme { get; set; }

        public virtual DateTime DatumRodjenja { get; set; }

        public virtual String Pol { get; set; }

        public virtual String Lozinka { get; set; }

        public virtual String Email { get; set; }

        public virtual long BrojTelefona { get; set; }

    }
}
