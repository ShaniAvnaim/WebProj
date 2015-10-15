using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppFinalProj.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required, Display(Name = "Course Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date), Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        // FK - one to many relationship
        public int InstructorId { get; set; }
        //public virtual Instructor Instructor { get; set; }

        // FK - many to many relationship
        [Display(Name = "Attending Students")]
        public virtual ICollection<Student> Students { get; set; }
    }
}