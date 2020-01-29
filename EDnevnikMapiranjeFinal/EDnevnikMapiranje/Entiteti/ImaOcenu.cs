using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class ImaOcenu
    {
        public virtual int Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual Ocena Ocena { get; set; }
        public virtual Ucenik Ucenik { get; set; }

    }
}
