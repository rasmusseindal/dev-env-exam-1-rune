namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfessions", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfessions", "Level");
        }
    }
}
