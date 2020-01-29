using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EDnevnikMapiranje;
using EDnevnikMapiranje.Entiteti;
using EDnevnikMapiranje.DTOs;

namespace EDnevnikWebApp.Controllers
{
    public class PredmetController : ApiController
    {
        public IEnumerable<PredmetView> Get()
        {
            DataProvider data = new DataProvider();
            return data.GetPredmetViews();
        }

        public PredmetView Get(int id)
        {
            DataProvider data = new DataProvider();
            return data.GetPredmetViewId(id);
        }

        //public int Put(int id, [FromBody]PredmetIzborni f)
        //{
        //    DataProvider provider = new DataProvider();
        //    return provider.UpdatePredmetIzborni(id, f);
        //}

        public int Put(int id, [FromBody]PredmetObavezni f)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePredmetObavezni(id, f);
        }


        public int Post([FromBody]Predmet f)
        {
            DataProvider provider = new DataProvider();
            return provider.AddPredmet(f);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePredmet(id);
        }

    }
}
