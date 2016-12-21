namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class holekeft : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "OwnerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "OwnerName");
        }
    }
}
