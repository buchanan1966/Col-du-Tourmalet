using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public JournalEntry Save(JournalEntry model)
        {
            this.Context.JournalEntries.AddOrUpdate(model);
            return model;
        }

        public void Delete(JournalEntry model)
        {
            var entity = this.Context.JournalEntries.SingleOrDefault(je => je.Id == model.Id);
            if (entity != null)
            {
                this.Context.JournalEntries.Remove(entity);
                this.Context.SaveChanges();
            }

            else
            {
                throw new Exception("Journal Entry not found!");
            }
        }
    }
}