using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ColduTourmalet.web.code.data;

namespace ColduTourmalet.web.code.business
{
    public class JournalEntryManager : IEntityManager<JournalEntry>
    {
        private ColduTourmaletDbContext Context;

        public JournalEntryManager(ColduTourmaletDbContext context)
        {
            Context = context;
        }

        public List<JournalEntry> GetAll()
        {
            return this.Context.JournalEntries.ToList();
        }

        public List<JournalEntry> GetFiltered(Expression<Func<JournalEntry, bool>> predicate)
        {
            return this.Context.JournalEntries.Where(predicate).ToList();
        }

        public JournalEntry Get(Expression<Func<JournalEntry, bool>> predicate)
        {
            return this.Context.JournalEntries.SingleOrDefault(predicate);
        }

        public JournalEntry Add(JournalEntry model)
        {
            throw new NotImplementedException();
        }

        public JournalEntry Update(JournalEntry model)
        {
            throw new NotImplementedException();
        }

        public JournalEntry Delete(JournalEntry model)
        {
            throw new NotImplementedException();
        }
    }
}