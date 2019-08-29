namespace Steam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "genre_Id", c => c.Int());
            CreateIndex("dbo.Games", "genre_Id");
            AddForeignKey("dbo.Games", "genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "genre_Id", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "genre_Id" });
            DropColumn("dbo.Games", "genre_Id");
            DropTable("dbo.Genres");
        }
    }
}
