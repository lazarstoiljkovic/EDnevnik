using EDnevnikMapiranje.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikMapiranje.DTOs
{
    public class FunkcijaView
    {
        public int idFunkcije { get; set; }
        public String TipFunckije { get; set; }

        public FunkcijaView()
        {

        }

        public FunkcijaView(Funkcija f)
        {
            idFunkcije = f.IdFunkcije;
            TipFunckije = f.TipFunkcije;
        }

    }




}
