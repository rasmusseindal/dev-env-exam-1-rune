namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions9 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfessions", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfessions", "UserId", c => c.Int(nullable: false));
        }
    }
}
