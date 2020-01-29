using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.DTOs
{
    public class UcenikView
    {

        public int idUcenika { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public int OcenaVladanje { get; set; }

        public UcenikView()
        {
            
        }
        public UcenikView(Ucenik u)
        {
            idUcenika = u.IdKorisnika;
            Ime = u.Ime;
            Prezime = u.Prezime;
            OcenaVladanje = u.OcenaVladanje;
        }
    }
}
