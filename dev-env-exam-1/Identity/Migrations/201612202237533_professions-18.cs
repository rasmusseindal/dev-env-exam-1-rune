namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfessions", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfessions", "UserId");
        }
    }
}
