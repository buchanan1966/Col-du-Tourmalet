﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColduTourmalet.web.code.data
{
    public class JournalEntry : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public List<JournalEntryTag> JournalEntryTags { get; set; }

    }

    public interface IEntity
    {
    }
}