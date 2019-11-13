using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class NPOApplication
    {
        [Key]
        public int Id { get; set; }
        public string OrgName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantPosition { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPhone { get; set; }
        public string NPOMission { get; set; }
        public string NPOVision { get; set; }
        public string WebURL { get; set; }
        public string ProblemsAndDesires { get; set; }
    }
}