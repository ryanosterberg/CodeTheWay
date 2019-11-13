using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class StudentApplication
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HighSchool { get; set; }
        public DateTime EstGradDate { get; set; }
        public bool WindowsLaptop { get; set; }
        public bool CSAComplete { get; set; }
        public bool PresentAllClassDates { get; set; }
        public string? MissedClassDates { get; set; }
        public bool PresentAllSeasonDates { get; set; }
        public string? MissedSeasonDates { get; set; }
    }
}