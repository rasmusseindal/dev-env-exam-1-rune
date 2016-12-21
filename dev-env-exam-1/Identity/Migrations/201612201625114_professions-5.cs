namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Companies", "Profession_ProfessionId", "dbo.Professions");
            DropForeignKey("dbo.AspNetUsers", "ProfessionId", "dbo.Professions");
            DropIndex("dbo.Companies", new[] { "Profession_ProfessionId" });
            DropIndex("dbo.AspNetUsers", new[] { "ProfessionId" });
            AddColumn("dbo.Professions", "CompanyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Professions", "CompanyId");
            AddForeignKey("dbo.Professions", "CompanyId", "dbo.Companies", "CompanyId", cascadeDelete: true);
            DropColumn("dbo.Companies", "Profession_ProfessionId");
            DropColumn("dbo.AspNetUsers", "ProfessionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "ProfessionId", c => c.Int());
            AddColumn("dbo.Companies", "Profession_ProfessionId", c => c.Int());
            DropForeignKey("dbo.Professions", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Professions", new[] { "CompanyId" });
            DropColumn("dbo.Professions", "CompanyId");
            CreateIndex("dbo.AspNetUsers", "ProfessionId");
            CreateIndex("dbo.Companies", "Profession_ProfessionId");
            AddForeignKey("dbo.AspNetUsers", "ProfessionId", "dbo.Professions", "ProfessionId");
            AddForeignKey("dbo.Companies", "Profession_ProfessionId", "dbo.Professions", "ProfessionId");
        }
    }
}
