namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class companylogo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "CompanyImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "CompanyImgPath");
        }
    }
}
