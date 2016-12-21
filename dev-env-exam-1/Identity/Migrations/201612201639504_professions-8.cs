namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfessions", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfessions", "ProfessionId", c => c.Int(nullable: false));
            AddColumn("dbo.UserProfessions", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.UserProfessions", "ProfessionId");
            CreateIndex("dbo.UserProfessions", "User_Id");
            AddForeignKey("dbo.UserProfessions", "ProfessionId", "dbo.Professions", "ProfessionId", cascadeDelete: true);
            AddForeignKey("dbo.UserProfessions", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfessions", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserProfessions", "ProfessionId", "dbo.Professions");
            DropIndex("dbo.UserProfessions", new[] { "User_Id" });
            DropIndex("dbo.UserProfessions", new[] { "ProfessionId" });
            DropColumn("dbo.UserProfessions", "User_Id");
            DropColumn("dbo.UserProfessions", "ProfessionId");
            DropColumn("dbo.UserProfessions", "UserId");
        }
    }
}
