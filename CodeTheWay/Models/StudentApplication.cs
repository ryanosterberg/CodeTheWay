﻿using System;
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
        [Required]
        //[RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [DisplayName("High School")]
        [Required]
        public string HighSchool { get; set; }
        [DisplayName("Estimated Graduation Date")]
        [Required]
        public DateTime EstGradDate { get; set; }
        [DisplayName("Do you have a Windows Laptop?")]
        public bool WindowsLaptop { get; set; }
        [DisplayName("Have you completed AP Computer Science or equivalent?")]
        public bool CSAComplete { get; set; }
        [DisplayName("If not, please detail the computer science classes you have taken and your computer programming experiences")]
        public string Accomplishments { get; set; }
        [DisplayName("Will you be here for all days of the Master Class?")]
        public bool PresentAllClassDates { get; set; }
        [DisplayName("If not, list all missed class days")]
        public string MissedClassDates { get; set; }
        [DisplayName("Will you be here for all days of the Project Season?")]
        public bool PresentAllSeasonDates { get; set; }
        [DisplayName("If not, list all missed season days")]
        public string MissedSeasonDates { get; set; }
    }
}