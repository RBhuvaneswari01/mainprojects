using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapidemo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        static List<string> mylist = new List<string>();
        public IEnumerable<string> Get()
        {
            // return new string[] { "value1", "value2" };
            mylist.Add("hello");
            mylist.Add("welcome");
            return mylist;   
        }

        // GET api/values/5
        public string Get(int id)
        {
            
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            mylist.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            
            mylist.RemoveAt(id);
            mylist.Insert(id,value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            mylist.RemoveAt(id);
        }
    }
}
