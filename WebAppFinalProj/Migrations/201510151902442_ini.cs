namespace WebAppFinalProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ini : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserCourses", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.UserCourses", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.UserCourses", new[] { "User_UserId" });
            DropIndex("dbo.UserCourses", new[] { "Course_CourseId" });
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        PhoneNum = c.String(),
                        CourseId = c.String(),
                        Course_CourseId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .Index(t => t.Course_CourseId);
            
            DropTable("dbo.Users");
            DropTable("dbo.UserCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserCourses",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.Course_CourseId });
            
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
            
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Course_CourseId" });
            DropTable("dbo.Students");
            CreateIndex("dbo.UserCourses", "Course_CourseId");
            CreateIndex("dbo.UserCourses", "User_UserId");
            AddForeignKey("dbo.UserCourses", "Course_CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
            AddForeignKey("dbo.UserCourses", "User_UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
    }
}
