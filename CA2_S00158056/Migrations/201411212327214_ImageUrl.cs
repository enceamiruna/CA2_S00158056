namespace CA2_S00158056.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "imageUrl", c => c.String());
            AddColumn("dbo.Movies", "description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "description");
            DropColumn("dbo.Movies", "imageUrl");
        }
    }
}
