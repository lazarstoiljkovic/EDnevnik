using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class PredajeID
    {
        public virtual Predmet Predmet { get; set; }
        public virtual NijeUcenik Nastavnik { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(PredajeID))
                return false;

            PredajeID recieveObject = (PredajeID)obj;
            if ((Predmet.IdPredmeta == recieveObject.Predmet.IdPredmeta) && 
                (Nastavnik.IdKorisnika == recieveObject.Nastavnik.IdKorisnika))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
