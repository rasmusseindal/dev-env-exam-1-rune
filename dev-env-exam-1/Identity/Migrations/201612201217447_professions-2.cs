namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        ProfessionId = c.Int(nullable: false, identity: true),
                        ProfessionName = c.String(),
                        ProfessionDescription = c.String(),
                    })
                .PrimaryKey(t => t.ProfessionId);
            
            AddColumn("dbo.Companies", "Profession_ProfessionId", c => c.Int());
            AddColumn("dbo.AspNetUsers", "ProfessionId", c => c.Int());
            CreateIndex("dbo.Companies", "Profession_ProfessionId");
            CreateIndex("dbo.AspNetUsers", "ProfessionId");
            AddForeignKey("dbo.Companies", "Profession_ProfessionId", "dbo.Professions", "ProfessionId");
            AddForeignKey("dbo.AspNetUsers", "ProfessionId", "dbo.Professions", "ProfessionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "ProfessionId", "dbo.Professions");
            DropForeignKey("dbo.Companies", "Profession_ProfessionId", "dbo.Professions");
            DropIndex("dbo.AspNetUsers", new[] { "ProfessionId" });
            DropIndex("dbo.Companies", new[] { "Profession_ProfessionId" });
            DropColumn("dbo.AspNetUsers", "ProfessionId");
            DropColumn("dbo.Companies", "Profession_ProfessionId");
            DropTable("dbo.Professions");
        }
    }
}
