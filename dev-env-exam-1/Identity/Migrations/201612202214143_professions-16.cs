namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions16 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserProfessions", name: "User_Id", newName: "UserId_Id");
            RenameIndex(table: "dbo.UserProfessions", name: "IX_User_Id", newName: "IX_UserId_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserProfessions", name: "IX_UserId_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.UserProfessions", name: "UserId_Id", newName: "User_Id");
        }
    }
}
