namespace AdaptorsInterfaces.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelRowCols : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Cols");
            DropColumn("dbo.Movies", "Rows");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Rows", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Cols", c => c.Int(nullable: false));
        }
    }
}
