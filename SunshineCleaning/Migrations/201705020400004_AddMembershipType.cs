namespace SunshineCleaning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DurationInDays = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clients", "MembershipTypeId");
            AddForeignKey("dbo.Clients", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Clients", new[] { "MembershipTypeId" });
            DropColumn("dbo.Clients", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
