using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class ObavljaFunkciju
    {
        public virtual ObavljaFunkcijuId Id { get; set; }
        public virtual DateTime datumOdFunkcija { get; set; }
        public virtual DateTime datumDoFunkcija { get; set; }

        public ObavljaFunkciju()
        {
            Id = new ObavljaFunkcijuId();
        }

    }
}
