using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class DrziPredmetOdeljenju
    {
        public virtual int Id { get; set; }
        public virtual NijeUcenik Nastavnik { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual Odeljenje Odeljenje { get; set; }
    }
}
