namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserProfessions", name: "User_Id", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.UserProfessions", name: "IX_User_Id", newName: "IX_ApplicationUser_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserProfessions", name: "IX_ApplicationUser_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.UserProfessions", name: "ApplicationUser_Id", newName: "User_Id");
        }
    }
}
