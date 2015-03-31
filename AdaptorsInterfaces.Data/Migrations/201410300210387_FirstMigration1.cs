namespace AdaptorsInterfaces.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumReview", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "AveRating", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AveRating");
            DropColumn("dbo.Movies", "NumReview");
        }
    }
}
