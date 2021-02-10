using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebapiDemo.Controllers
{
    public class NamesController : ApiController
    {
        static List<string> trainees = new List<string>()
       {
           "shaswat","abhi","aneena","srivatsha","ankita"
       };

        [HttpGet]
        public IEnumerable<string> ProvideData()
        {
            return trainees;
        }
        [HttpGet]
        public string suppydata(int id)
        {
            return trainees[id];
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            trainees.Add(value);
        }

        public void Put(int id,[FromBody]string values)
        {
            trainees[id] = values;
        }

        public void Delete(int id)
        {
            trainees.RemoveAt(id);
        }


    }
}
