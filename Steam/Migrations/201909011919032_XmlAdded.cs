namespace Steam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XmlAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "listOfImages", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "listOfImages");
        }
    }
}
