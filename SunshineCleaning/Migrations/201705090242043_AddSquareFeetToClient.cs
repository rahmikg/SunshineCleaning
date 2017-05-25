namespace SunshineCleaning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSquareFeetToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "SquareFeet", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "SquareFeet");
        }
    }
}
