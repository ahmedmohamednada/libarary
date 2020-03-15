namespace libraryTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerName", c => c.String());
            DropColumn("dbo.Customers", "CustonerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustonerName", c => c.String());
            DropColumn("dbo.Customers", "CustomerName");
        }
    }
}
