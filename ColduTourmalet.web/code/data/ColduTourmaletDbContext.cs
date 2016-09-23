﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColduTourmalet.web.code.data
{
    public class ColduTourmaletDbContext : DbContext
    {
        public ColduTourmaletDbContext() : base("ColduTourmaletDb")
        {
            
        }

        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}