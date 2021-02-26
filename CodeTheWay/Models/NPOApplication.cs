using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class NPOApplication
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Organization Name")]
        [Required]
        public string OrgName { get; set; }

        [EmailAddress]
        // [Required] This thing broke your NPO requests for the last 9 months
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        [Phone]
        public string PhoneNum { get; set; }

        public string Address { get; set; }

        [DisplayName("Applicant First Name")]
        [Required]
        public string ApplicantFirstName { get; set; }

        [DisplayName("Applicant Last Name")]
        [Required]
        public string ApplicantLastName { get; set; }

        [DisplayName("Applicant Position")]
        [Required]
        public string ApplicantPosition { get; set; }

        [DisplayName("Applicant Email")]
        [EmailAddress]
        public string ApplicantEmail { get; set; }

        [DisplayName("Applicant Phone Number")]
        [Phone]
        public string ApplicantPhone { get; set; }

        [DisplayName("Mission")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string NPOMission { get; set; }

        [DisplayName("Vision")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string NPOVision { get; set; }

        [DisplayName("Website URL")]
        [Url]
        public string WebURL { get; set; }

        [DisplayName("How can Code The Way help you?")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string ProblemsAndDesires { get; set; }
    }
}