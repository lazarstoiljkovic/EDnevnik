using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.Entiteti
{
    public class Predaje
    {
        public virtual PredajeID ID { get; set; }
        public virtual String PlanIProgram { get; set; }

        public Predaje()
        {
            ID = new PredajeID();
        }
    }
}
