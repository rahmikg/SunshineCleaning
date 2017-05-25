namespace SunshineCleaning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, DurationInDays) VALUES (1, 1)");
            Sql("INSERT INTO MembershipTypes (Id, DurationInDays) VALUES (2, 7)");
            Sql("INSERT INTO MembershipTypes (Id, DurationInDays) VALUES (3, 14)");
            Sql("INSERT INTO MembershipTypes (Id, DurationInDays) VALUES (4, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
