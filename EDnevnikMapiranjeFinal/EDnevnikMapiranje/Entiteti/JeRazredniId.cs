using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class JeRazredniId
    {
        public virtual Odeljenje ImaRazrednog { get; set; }
        public virtual NijeUcenik JeRazredniOdeljenju { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(JeRazredniId))
                return false;

            JeRazredniId receiveObject = (JeRazredniId)obj;

            if ((ImaRazrednog.IdOdeljenja == receiveObject.ImaRazrednog.IdOdeljenja) && (JeRazredniOdeljenju.IdKorisnika == receiveObject.JeRazredniOdeljenju.IdKorisnika))
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
