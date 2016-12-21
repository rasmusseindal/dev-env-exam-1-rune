namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "Name_Id", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUsers", new[] { "Name_Id" });
            DropColumn("dbo.AspNetUsers", "Name_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Name_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "Name_Id");
            AddForeignKey("dbo.AspNetUsers", "Name_Id", "dbo.AspNetRoles", "Id");
        }
    }
}
