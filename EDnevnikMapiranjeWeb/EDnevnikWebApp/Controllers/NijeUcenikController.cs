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
    public class NijeUcenikController : ApiController
    {

        public IEnumerable<NijeUcenikView> Get()
        {
            DataProvider data = new DataProvider();
            return data.GetNijeUcenikViews();
        }

        public NijeUcenikView Get(int id)
        {
            DataProvider data = new DataProvider();
            return data.GetNijeUcenikViewId(id);
        }

        public int Put(int id, [FromBody]NijeUcenik f)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateNijeUcenik(id, f);
        }

        public int Post([FromBody]NijeUcenik f)
        {
            DataProvider provider = new DataProvider();
            return provider.AddNijeUcenik(f);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveNijeUcenik(id);
        }

    }
}
