namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRedundatColumnInUsers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Companies", "AllUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "AllUsers_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Companies", new[] { "AllUsers_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "AllUsers_Id" });
            DropColumn("dbo.Companies", "AllUsers_Id");
            DropColumn("dbo.AspNetUsers", "AllUsers_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "AllUsers_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Companies", "AllUsers_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "AllUsers_Id");
            CreateIndex("dbo.Companies", "AllUsers_Id");
            AddForeignKey("dbo.AspNetUsers", "AllUsers_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Companies", "AllUsers_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
