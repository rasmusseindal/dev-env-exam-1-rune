namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfessions", "startLevel", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfessions", "goalLevel", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfessions", "startDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserProfessions", "Level");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfessions", "Level", c => c.Int(nullable: false));
            DropColumn("dbo.UserProfessions", "startDate");
            DropColumn("dbo.UserProfessions", "goalLevel");
            DropColumn("dbo.UserProfessions", "startLevel");
        }
    }
}
