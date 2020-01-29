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
    public class OcenaController : ApiController
    {

        public IEnumerable<OcenaView> Get()
        {
            DataProvider data = new DataProvider();
            return data.GetOcenaViews();
        }

        public OcenaView Get(int id)
        {
            DataProvider data = new DataProvider();
            return data.GetOcenaViewId(id);
        }

        public int Put(int id, [FromBody]Ocena f)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateOcena(id, f);
        }

        public int Post([FromBody]Ocena f)
        {
            DataProvider provider = new DataProvider();
            return provider.AddOcena(f);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveOcena(id);
        }

    }
}
