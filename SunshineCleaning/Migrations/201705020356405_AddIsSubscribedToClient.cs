namespace SunshineCleaning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "IsSubscribedToNewsLetter");
        }
    }
}
