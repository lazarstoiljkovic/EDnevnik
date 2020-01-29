using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDnevnikMapiranje;
using EDnevnikMapiranje.DTOs;
using EDnevnikMapiranje.Entiteti;

namespace TestWeb.Controllers
{
    public class OdeljenjeController : Controller
    {
        public IEnumerable<Odeljenje> Get()
        {
            DataProvider provider = new DataProvider();
            IEnumerable<Odeljenje> odeljenja = provider.GetOdeljenja();
            //return new[]
            //{
            //    new Odeljenje() {Naziv="test"}
            //};
            return odeljenja;
        }

        public OdeljenjeView GetOdeljenjeId(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetOdeljenjeView(id);
        }

        public ActionResult Prikazi(int id)
        {
            DataProvider provider = new DataProvider();
            String con = "";
            IEnumerable<Odeljenje> odeljenja = provider.GetOdeljenja();
            foreach(Odeljenje o in odeljenja)
            {
                con += "Naziv : " + o.Naziv + "  Smer : " + o.Smer + "</br>";
            }


            return Content(con);
        }
    }
}