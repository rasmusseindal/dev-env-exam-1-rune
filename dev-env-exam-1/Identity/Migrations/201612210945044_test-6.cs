namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test6 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserProfessions", name: "ApplicationUser_Id", newName: "UserId");
            RenameIndex(table: "dbo.UserProfessions", name: "IX_ApplicationUser_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserProfessions", name: "IX_UserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.UserProfessions", name: "UserId", newName: "ApplicationUser_Id");
        }
    }
}
