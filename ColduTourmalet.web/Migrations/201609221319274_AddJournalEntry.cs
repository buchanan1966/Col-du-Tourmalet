namespace ColduTourmalet.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJournalEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JournalEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JournalEntryTags",
                c => new
                    {
                        JournalEntryId = c.Int(nullable: false),
                        TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.JournalEntryId, t.TagId })
                .ForeignKey("dbo.JournalEntries", t => t.JournalEntryId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.JournalEntryId)
                .Index(t => t.TagId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JournalEntryTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.JournalEntryTags", "JournalEntryId", "dbo.JournalEntries");
            DropIndex("dbo.JournalEntryTags", new[] { "TagId" });
            DropIndex("dbo.JournalEntryTags", new[] { "JournalEntryId" });
            DropTable("dbo.Tags");
            DropTable("dbo.JournalEntryTags");
            DropTable("dbo.JournalEntries");
        }
    }
}
