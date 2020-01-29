using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikMapiranje.DTOs
{
    public class NijeUcenikView
    {

        public int idNijeUcenik { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public virtual String AdministratorFlag { get; set; }
        public virtual String NastavnigFlag { get; set; }
        public virtual String RoditeljFlag { get; set; }

        public NijeUcenikView()
        {

        }
        public NijeUcenikView(NijeUcenik k)
        {
            idNijeUcenik = k.IdKorisnika;
            Ime = k.Ime;
            Prezime = k.Prezime;
            AdministratorFlag = k.AdministratorFlag;
            NastavnigFlag = k.NastavnigFlag;
            RoditeljFlag = k.RoditeljFlag;
        }


    }
}
