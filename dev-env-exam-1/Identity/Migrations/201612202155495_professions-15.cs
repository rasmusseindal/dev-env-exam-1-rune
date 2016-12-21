namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfessions", "startLevel", c => c.String());
            AddColumn("dbo.UserProfessions", "goalLevel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfessions", "goalLevel");
            DropColumn("dbo.UserProfessions", "startLevel");
        }
    }
}
