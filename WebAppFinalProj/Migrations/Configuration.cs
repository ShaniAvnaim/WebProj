namespace WebAppFinalProj.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using WebAppFinalProj.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppFinalProj.Models.AcademyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebAppFinalProj.Models.AcademyDbContext";
        }

        protected override void Seed(WebAppFinalProj.Models.AcademyDbContext context)
        {
            var Instructor1 = new Instructor { InstructorId = 1, FirstName = "Sylvia", LastName = "Terrence", EmailAddress = "SylviaT@MakeItUp.com", PhoneNum = "052-9865367", Courses = new List<Course>() };
            var Instructor2 = new Instructor { InstructorId = 2, FirstName = "Daria", LastName = "Robby", EmailAddress = "DariaR@MakeItUp.com", PhoneNum = "054-9287739", Courses = new List<Course>() };
            var Instructor3 = new Instructor { InstructorId = 3, FirstName = "Josh", LastName = "Gilbert", EmailAddress = "JoshG@MakeItUp.com", PhoneNum = "050-4592344", Courses = new List<Course>() };

            var User1 = new User { UserId = 1, FirstName = "Debi", LastName = "Lolicia", EmailAddress = "Debi88@gmail.com", PhoneNum = "054-7399128", Password = "123456", Role = "User", Courses = new List<Course>() };
            var User2 = new User { UserId = 2, FirstName = "Dotty", LastName = "Scottie", EmailAddress = "Dotty4ever@gmail.com", PhoneNum = "050-9735724", Password = "123456", Role = "User", Courses = new List<Course>() };
            var User3 = new User { UserId = 3, FirstName = "Mort", LastName = "Raelenc", EmailAddress = "Angel69Kitty@gmail.com", PhoneNum = "077-8364152", Password = "123456", Role = "User", Courses = new List<Course>() };
            var Admin = new User { UserId = 4, FirstName = "Admin", LastName = "Admin", EmailAddress = "Admin@MakeItUp.com", PhoneNum = "1800-906090", Password = "123456", Role = "Admin", Courses = new List<Course>() };

            var Course1 = new Course
            {
                CourseId = 1,
                Name = "Skin Sculpting",
                Description = "Discover the tips and tricks professional make-up has to offer when it comes to adding definition, light and dimension to facial contours. Take a step further than just creating a flawless base and master important techniques in this intensive 2 hour course with the help of the professionals.",
                Address = "Weizmann St 28, Tel Aviv-Yafo, Israel",
                X = 32.084430,
                Y = 34.789305,
                StartDate = new DateTime(2015, 2, 12, 17, 0, 0),
                EndDate = new DateTime(2015, 2, 26, 17, 0, 0),
                InstructorId = 1,
                Users = new List<User>()
            };
            var Course2 = new Course
            {
                CourseId = 2,
                Name = "Skin Realism",
                Description = "Modernize the look of your skin and experiment with innovative and award-winning textures to discover a new dimension to your skin. Master the skill of creating a beautiful canvas, find your perfect foundation shade and learn about a multitude of different finishes you can achieve with the help of the professionals.",
                Address = "Derech Yitshak Rabin 18, Petah Tikva, Israel",
                X = 32.088472,
                Y = 34.861423,
                StartDate = new DateTime(2015, 3, 7, 17, 0, 0),
                EndDate = new DateTime(2015, 4, 1, 17, 0, 0),
                InstructorId = 2,
                Users = new List<User>()
            };
            var Course3 = new Course
            {
                CourseId = 3,
                Name = "Eye Llining Designs",
                Description = "Favoured by celebrities and the majority of women, eye liner is here to stay. This two hour intensive course is designed to allow you to execute your eye liner design to perfection as well as inspiring you to experiment and learn different ways on how to frame your eyes. Eyes are the windows of the soul after all!",
                Address = "Herzl St 29, Rehovot, Israel",
                X = 31.884092,
                Y = 34.815928,
                StartDate = new DateTime(2015, 2, 5, 17, 0, 0),
                EndDate = new DateTime(2015, 2, 9, 17, 0, 0),
                InstructorId = 3,
                Users = new List<User>()
            };
            var Course4 = new Course
            {
                CourseId = 4,
                Name = "Smokey Eye Design",
                Description = "Smoulder, seduce and captivate - this two hour course will help you master the art of blending and creating the perfect smokey eye. Learn this iconic eye make-up design with help from the professionals and experiment with different tools, products and styles to discover the secret to unlocking the windows of your soul!",
                Address = "Sokolov St 30, Haifa, Israel",
                X = 32.808374,
                Y = 35.003414,
                StartDate = new DateTime(2015, 2, 10, 17, 0, 0),
                EndDate = new DateTime(2015, 2, 17, 17, 0, 0),
                InstructorId = 3,
                Users = new List<User>()
            };

            Instructor1.Courses.Add(Course1);
            Instructor2.Courses.Add(Course2);
            Instructor3.Courses.Add(Course3);
            Instructor3.Courses.Add(Course4);

            User1.Courses.Add(Course1);
            User2.Courses.Add(Course2);
            User3.Courses.Add(Course2);
            User3.Courses.Add(Course3);

            context.Instructors.Add(Instructor1);
            context.Instructors.Add(Instructor2);
            context.Instructors.Add(Instructor3);

            context.Users.Add(User1);
            context.Users.Add(User2);
            context.Users.Add(User3);
            context.Users.Add(Admin);

            context.Courses.Add(Course1);
            context.Courses.Add(Course2);
            context.Courses.Add(Course3);
            context.Courses.Add(Course4);
        }
    }
}
