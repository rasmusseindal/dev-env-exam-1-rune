namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class professions6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfessions",
                c => new
                    {
                        UserProfessionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UserProfessionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfessions");
        }
    }
}
