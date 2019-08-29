namespace Steam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        coverImage = c.String(),
                        description = c.String(),
                        developer = c.String(),
                        rating = c.Single(nullable: false),
                        discount = c.Single(nullable: false),
                        sold = c.Int(nullable: false),
                        dateAdded = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                        User_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(),
                        rating = c.Single(nullable: false),
                        date = c.DateTime(nullable: false),
                        user_Id = c.Int(),
                        Game_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.user_Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.user_Id)
                .Index(t => t.Game_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nickname = c.String(),
                        avatar = c.String(),
                        info = c.String(),
                        level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Games", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.Reviews", "user_Id", "dbo.Users");
            DropForeignKey("dbo.Games", "User_Id", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "Game_Id" });
            DropIndex("dbo.Reviews", new[] { "user_Id" });
            DropIndex("dbo.Games", new[] { "User_Id1" });
            DropIndex("dbo.Games", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Reviews");
            DropTable("dbo.Games");
        }
    }
}
