using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ColduTourmalet.web.Controllers
{
    public class EntryController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            
            var entries = new List<Entry> ();
            for (int i = 0; i < 10; i++)
            {
                entries.Add(new Entry(i));
            }
            return Ok(entries);
        }
    }

    public class Entry
    {
        public Entry(int i)
        {
            Title = string.Format("BLAH {0}", i);
            Content = "BLAH BLAH BLAH";
        }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
