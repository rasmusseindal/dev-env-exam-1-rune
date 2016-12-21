namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions14 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfessions", "startLevel");
            DropColumn("dbo.UserProfessions", "goalLevel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfessions", "goalLevel", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfessions", "startLevel", c => c.Int(nullable: false));
        }
    }
}
