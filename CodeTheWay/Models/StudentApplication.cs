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
        //bool? IBCSAComplete { get; set; } should be covered by APCSA cause its equivalent class, so generalize?
        public bool PresentAllClassDates { get; set; }
        public List<DateTime>? MissedClassDates { get; set; }
        public bool PresentAllSeasonDates { get; set; }
        public List<DateTime>? MissedSeasonDates { get; set; }
    }
}