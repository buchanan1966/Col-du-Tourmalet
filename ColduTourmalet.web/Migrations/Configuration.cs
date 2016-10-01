using System.Collections.Generic;
using ColduTourmalet.web.code.data;

namespace ColduTourmalet.web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ColduTourmalet.web.code.data.ColduTourmaletDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ColduTourmalet.web.code.data.ColduTourmaletDbContext context)
        {
            context.Tags.AddOrUpdate(
                p => p.Name,
                new Tag { Name = "Tag 1"},
                new Tag { Name = "Tag 2"},
                new Tag { Name = "Tag 3"},
                new Tag { Name = "Tag 4"},
                new Tag { Name = "Tag 5"},
                new Tag { Name = "Tag 6"},
                new Tag { Name = "Tag 7"},
                new Tag { Name = "Tag 8"},
                new Tag { Name = "Tag 9"},
                new Tag { Name = "Tag 10"},
                new Tag { Name = "Tag 11"}
                );

            context.JournalEntries.AddOrUpdate(
                p => p.Title,
                new JournalEntry
                {
                    Created = DateTime.Now,
                    Title = "The First One",
                    Content = "BLAH BLAH BLAH!!!!"
                }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
