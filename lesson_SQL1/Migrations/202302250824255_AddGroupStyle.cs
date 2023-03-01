namespace lesson_SQL1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupStyle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Style", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Style");
        }
    }
}
