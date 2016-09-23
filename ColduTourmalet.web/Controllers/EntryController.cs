﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ColduTourmalet.web.code.business;
using ColduTourmalet.web.code.data;

namespace ColduTourmalet.web.Controllers
{
    public class EntryController : ApiController
    {
        private IEntityManager<JournalEntry> JournalEntryManager;

        public EntryController(IEntityManager<JournalEntry> journalEntryManager)
        {
            JournalEntryManager = journalEntryManager;
        }
        // GET api/values
        public IHttpActionResult Get()
        {
            var result = this.JournalEntryManager.GetAll();
            return Ok(result);
        }
    }

    public class Entry
    {
        public Entry(int i)
        {
            Title = string.Format("BLAH {0}", i);
            Date = DateTime.Now;
            Content = "BLAH BLAH BLAH";
        }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
