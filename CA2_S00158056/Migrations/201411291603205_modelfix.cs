namespace CA2_S00158056.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelfix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Actors", "actorName", c => c.String(nullable: false));
            AlterColumn("dbo.Actors", "description", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "movieName", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "description", c => c.String());
            AlterColumn("dbo.Movies", "movieName", c => c.String());
            AlterColumn("dbo.Actors", "description", c => c.String());
            AlterColumn("dbo.Actors", "actorName", c => c.String());
        }
    }
}
