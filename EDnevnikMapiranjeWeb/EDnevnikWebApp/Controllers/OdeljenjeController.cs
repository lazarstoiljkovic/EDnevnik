using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EDnevnikMapiranje.Entiteti;
using EDnevnikMapiranje;
using EDnevnikMapiranje.DTOs;

namespace EDnevnikWebApp.Controllers
{
    public class OdeljenjeController : ApiController
    {
        public IEnumerable<OdeljenjeView> Get()
        {
            DataProvider provider = new DataProvider();
            IEnumerable<OdeljenjeView> odeljenja = provider.GetOdeljenjaView();

            return odeljenja;
        }

        public OdeljenjeView Get(int id)
        {
            DataProvider provider = new DataProvider();

            return provider.GetOdeljenjeView(id);
        }
        public int Put(int id, [FromBody]Odeljenje o)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateOdeljenje(id,o);
        }

        public int Post([FromBody]Odeljenje o)
        {
            DataProvider provider = new DataProvider();
            return provider.AddOdeljenje(o);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveOdeljenje(id);
        }

        
    }
}
