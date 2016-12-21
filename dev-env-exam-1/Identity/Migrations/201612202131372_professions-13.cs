namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfessions", "startLevel", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfessions", "goalLevel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfessions", "goalLevel");
            DropColumn("dbo.UserProfessions", "startLevel");
        }
    }
}
