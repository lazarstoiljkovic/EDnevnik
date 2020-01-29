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
    public class UcenikController : ApiController
    {

        public IEnumerable<UcenikView> Get()
        {
            DataProvider data = new DataProvider();
            return data.GetUcenikViews();
        }

        public UcenikView Get(int id)
        {
            DataProvider data = new DataProvider();
            return data.GetUcenikViewId(id);
        }

        public int Put(int id, [FromBody]Ucenik f)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateUcenik(id, f);
        }

        public int Post([FromBody]Ucenik f)
        {
            DataProvider provider = new DataProvider();
            return provider.AddUcenik(f);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveUcenik(id);
        }
    }
}
