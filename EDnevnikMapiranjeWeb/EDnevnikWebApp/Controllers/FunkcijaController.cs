using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EDnevnikMapiranje;
using EDnevnikMapiranje.DTOs;
using EDnevnikMapiranje.Entiteti;

namespace EDnevnikWebApp.Controllers
{
    public class FunkcijaController : ApiController
    {
        public IEnumerable<FunkcijaView> Get()
        {
            DataProvider data = new DataProvider();
            return data.GetFunkcijaViews();
        }

        public FunkcijaView Get(int id)
        {
            DataProvider data = new DataProvider();
            return data.GetFunkcijaViewId(id);
        }

        public int Put(int id, [FromBody]Funkcija f)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateFunkciju(id,f);
        }

        public int Post([FromBody]Funkcija f)
        {
            DataProvider provider = new DataProvider();
            return provider.AddFunkcija(f);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveFunkcija(id);
        }

    }
}
