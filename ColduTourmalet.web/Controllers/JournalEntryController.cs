using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ColduTourmalet.web.code.business;
using ColduTourmalet.web.code.data;

namespace ColduTourmalet.web.Controllers
{
    public class JournalEntryController : ApiController
    {
        private IEntityManager<JournalEntry> JournalEntryManager;

        public JournalEntryController(IEntityManager<JournalEntry> journalEntryManager)
        {
            JournalEntryManager = journalEntryManager;
        }
        // GET api/values
        public IHttpActionResult Get()
        {
            var result = this.JournalEntryManager.GetAll();
            return Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = this.JournalEntryManager.Get(je => je.Id == id);
            return Ok(result);
        }
    }
}
