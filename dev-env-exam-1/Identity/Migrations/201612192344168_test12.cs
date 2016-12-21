namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "AllUsers_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUsers", "AllUsers_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Companies", "AllUsers_Id");
            CreateIndex("dbo.AspNetUsers", "AllUsers_Id");
            AddForeignKey("dbo.Companies", "AllUsers_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUsers", "AllUsers_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "AllUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Companies", "AllUsers_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "AllUsers_Id" });
            DropIndex("dbo.Companies", new[] { "AllUsers_Id" });
            DropColumn("dbo.AspNetUsers", "AllUsers_Id");
            DropColumn("dbo.AspNetUsers", "Discriminator");
            DropColumn("dbo.Companies", "AllUsers_Id");
        }
    }
}
