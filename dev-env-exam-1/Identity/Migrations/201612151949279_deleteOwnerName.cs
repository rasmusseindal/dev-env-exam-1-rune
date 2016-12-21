namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteOwnerName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "OwnerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "OwnerName", c => c.String());
        }
    }
}
