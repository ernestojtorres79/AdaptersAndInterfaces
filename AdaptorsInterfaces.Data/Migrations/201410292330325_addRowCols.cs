namespace AdaptorsInterfaces.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRowCols : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Cols", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Rows", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rows");
            DropColumn("dbo.Movies", "Cols");
        }
    }
}
