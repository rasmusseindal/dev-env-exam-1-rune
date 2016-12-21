namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addroletodb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RoleId", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Name_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "Name_Id");
            AddForeignKey("dbo.AspNetUsers", "Name_Id", "dbo.AspNetRoles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Name_Id", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUsers", new[] { "Name_Id" });
            DropColumn("dbo.AspNetUsers", "Name_Id");
            DropColumn("dbo.AspNetUsers", "RoleId");
        }
    }
}
