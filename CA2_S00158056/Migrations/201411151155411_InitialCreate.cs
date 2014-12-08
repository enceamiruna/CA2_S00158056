namespace CA2_S00158056.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        actorID = c.Int(nullable: false, identity: true),
                        actorName = c.String(),
                    })
                .PrimaryKey(t => t.actorID);
            
            CreateTable(
                "dbo.ScreenNames",
                c => new
                    {
                        movieID = c.Int(nullable: false),
                        actorID = c.Int(nullable: false),
                        screenName = c.String(),
                    })
                .PrimaryKey(t => new { t.movieID, t.actorID })
                .ForeignKey("dbo.Actors", t => t.actorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.movieID, cascadeDelete: true)
                .Index(t => t.movieID)
                .Index(t => t.actorID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        movieID = c.Int(nullable: false, identity: true),
                        movieName = c.String(),
                    })
                .PrimaryKey(t => t.movieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScreenNames", "movieID", "dbo.Movies");
            DropForeignKey("dbo.ScreenNames", "actorID", "dbo.Actors");
            DropIndex("dbo.ScreenNames", new[] { "actorID" });
            DropIndex("dbo.ScreenNames", new[] { "movieID" });
            DropTable("dbo.Movies");
            DropTable("dbo.ScreenNames");
            DropTable("dbo.Actors");
        }
    }
}
