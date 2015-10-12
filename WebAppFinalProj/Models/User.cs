using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppFinalProj.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }

        [Required, Display(Name = "Password")]
        public string Password { get; set; }

        [Required, Display(Name = "Role")]
        public string Role { get; set; }

        [Display(Name = "Courses")]
        public virtual List<Course> Courses { get; set; }
    }
}