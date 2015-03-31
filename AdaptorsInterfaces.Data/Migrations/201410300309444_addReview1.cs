namespace AdaptorsInterfaces.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReview1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        ReviewUser = c.String(),
                        ReviewBody = c.String(),
                        TimePosted = c.DateTime(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            DropTable("dbo.Reviews");
        }
    }
}
