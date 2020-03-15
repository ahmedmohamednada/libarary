namespace libraryTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationBook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Book", "BookName", c => c.String(nullable: false));
            AlterColumn("dbo.Book", "AuthorName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Book", "AuthorName", c => c.String());
            AlterColumn("dbo.Book", "BookName", c => c.String());
        }
    }
}
