namespace WebAppFinalProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "X", c => c.Double(nullable: false));
            AddColumn("dbo.Courses", "Y", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Y");
            DropColumn("dbo.Courses", "X");
        }
    }
}
