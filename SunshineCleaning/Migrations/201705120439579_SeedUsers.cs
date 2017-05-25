namespace SunshineCleaning.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'52607178-4bfa-4748-8834-a233517bde5f', N'Admin@SunshineCleaning.com', 0, N'AC0ezgF681lRG0ToulgI0rJ333ZENcGMGf8Pzb7DcfnILwxlL1ThoPQmeQ7y7czS4Q==', N'bddc0a57-aea2-482c-bbb6-f882cc81f730', NULL, 0, 0, NULL, 1, 0, N'Admin@SunshineCleaning.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a96856e7-024a-4c2d-829f-ff59de5cf51c', N'guest@sunshine.com', 0, N'ACWFXjlSEcj7qp8vwAG4+LNvnwk5jQND5AxWc4BLv6YK1jX5mcwInKXGxv2WwWvzMA==', N'aad54ecf-72d5-4540-a2ee-c38d17535213', NULL, 0, 0, NULL, 1, 0, N'guest@sunshine.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'916a8183-772a-4eb3-9e5a-4ecdbaccd2e8', N'CanManageClient')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'52607178-4bfa-4748-8834-a233517bde5f', N'916a8183-772a-4eb3-9e5a-4ecdbaccd2e8')


");
        }
        
        public override void Down()
        {
        }
    }
}
