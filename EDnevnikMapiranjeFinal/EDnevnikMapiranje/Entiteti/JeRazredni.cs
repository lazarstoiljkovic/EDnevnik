using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class JeRazredni
    {        
        public virtual JeRazredniId Id { get; set; }
        public virtual DateTime datumOdStaresina { get; set; }
        public virtual DateTime datumDoStaresina { get; set; }

        public JeRazredni()
        {
            Id = new JeRazredniId();
        }
    }
}
