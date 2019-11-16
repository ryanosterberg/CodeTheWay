using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class StudentApplication
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DisplayName("High School")]
        [Required]
        public string HighSchool { get; set; }

        [DisplayName("Estimated Graduation Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EstGradDate { get; set; }

        [DisplayName("Windows Laptop?")]
        public bool WindowsLaptop { get; set; }

        [DisplayName("CSA Complete?")]
        public bool CSAComplete { get; set; }

        [DataType(DataType.MultilineText)]
        public string Accomplishments { get; set; }

        [DisplayName("Present all class dates?")]
        public bool PresentAllClassDates { get; set; }

        [DisplayName("Missed class dates")]
        public string MissedClassDates { get; set; }

        [DisplayName("Present all season dates?")]
        public bool PresentAllSeasonDates { get; set; }

        [DisplayName("Missed season dates")]
        public string MissedSeasonDates { get; set; }
    }
}