using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ColduTourmalet.web.code.business;
using ColduTourmalet.web.code.data;
using Moq;
using NUnit.Framework;

namespace ColduTourmalet.tests.code.business
{
    [TestFixture]
    public class JourlalEntryManagerTests
    {
        private IEntityManager<JournalEntry> Manager;
        private Mock<ColduTourmaletDbContext> MockDbContext;

        [SetUp]
        public void Setup()
        {
            this.MockDbContext = new Mock<ColduTourmaletDbContext>();
            this.Manager = new JournalEntryManager(this.MockDbContext.Object);
        }

        [Test]
        public void GetAll()
        {
            var data = new List<JournalEntry>
            {
                new JournalEntry {Id = 1, Title = "BLAH" }
            }.AsQueryable();

            SetupMockContext(data);
            var result = this.Manager.GetAll();

            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void Get()
        {
            var data = new List<JournalEntry>
            {
                new JournalEntry {Id = 1, Title = "BLAH" },
                new JournalEntry {Id = 2, Title = "BLAH2" }
            }.AsQueryable();

            SetupMockContext(data);
            var result = this.Manager.Get(je => je.Id == 1);

            Assert.IsTrue(result.Id == 1);
        }

        [Test]
        public void GetFiltered()
        {
            var data = new List<JournalEntry>
            {
                new JournalEntry {Id = 1, Title = "BLAH" },
                new JournalEntry {Id = 2, Title = "BLAH2" }
            }.AsQueryable();

            SetupMockContext(data);
            var result = this.Manager.GetFiltered(je => je.Id == 2);

            Assert.AreEqual(1, result.Count);
            Assert.That(result[0].Id == 2);
        }

        private void SetupMockContext(IQueryable<JournalEntry> data)
        {
            var mockSet = new Mock<DbSet<JournalEntry>>();
            mockSet.As<IQueryable<JournalEntry>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<JournalEntry>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<JournalEntry>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<JournalEntry>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());
            this.MockDbContext.Setup(c => c.JournalEntries).Returns(mockSet.Object);
        }
    }
}