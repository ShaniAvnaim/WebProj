namespace WebAppFinalProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false, storeType: "date"),
                        EndDate = c.DateTime(nullable: false, storeType: "date"),
                        InstructorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Instructors", t => t.InstructorId, cascadeDelete: true)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        PhoneNum = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        PhoneNum = c.String(),
                        Password = c.String(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserCourses",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.Course_CourseId })
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.UserCourses", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Courses", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.UserCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.UserCourses", new[] { "User_UserId" });
            DropIndex("dbo.Courses", new[] { "InstructorId" });
            DropTable("dbo.UserCourses");
            DropTable("dbo.Users");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
        }
    }
}
