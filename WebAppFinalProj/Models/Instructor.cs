using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppFinalProj.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required, Display(Name = "Phome Number")]
        public string PhoneNum { get; set; }

        [Display(Name = "Courses")]
        public List<Course> Courses { get; set; }
    }

    public class CoursesInstructors
    {
        public int InstId { get; set; }
        public string InstFName { get; set; }
        public string InstLName { get; set; }
    }
} 