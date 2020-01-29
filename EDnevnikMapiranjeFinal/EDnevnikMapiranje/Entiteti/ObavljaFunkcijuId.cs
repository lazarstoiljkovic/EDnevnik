using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class ObavljaFunkcijuId
    {
        public virtual NijeUcenik ObavljaFunkciju { get; set; }
        public virtual Funkcija ObavljaSe { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(ObavljaFunkcijuId))
                return false;

            ObavljaFunkcijuId receiveObject = (ObavljaFunkcijuId)obj;

            if ((ObavljaFunkciju.IdKorisnika==receiveObject.ObavljaFunkciju.IdKorisnika) && (ObavljaSe.IdFunkcije==receiveObject.ObavljaSe.IdFunkcije))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
