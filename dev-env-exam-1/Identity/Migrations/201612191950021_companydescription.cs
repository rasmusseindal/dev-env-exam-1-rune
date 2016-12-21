namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class companydescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "CompanyDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "CompanyDescription");
        }
    }
}
