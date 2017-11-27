namespace SimpleGuestBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataInitMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GuestbookEntries", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.GuestbookEntries", "Message", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GuestbookEntries", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.GuestbookEntries", "Name", c => c.String(nullable: false));
        }
    }
}
