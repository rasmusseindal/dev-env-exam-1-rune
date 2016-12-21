namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            AddColumn("dbo.AspNetUsers", "OwnerName", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "CompanyId");
            AddForeignKey("dbo.AspNetUsers", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "CompanyId", "dbo.Companies");
            DropIndex("dbo.AspNetUsers", new[] { "CompanyId" });
            DropColumn("dbo.AspNetUsers", "CompanyId");
            DropColumn("dbo.AspNetUsers", "OwnerName");
            DropTable("dbo.Companies");
        }
    }
}
