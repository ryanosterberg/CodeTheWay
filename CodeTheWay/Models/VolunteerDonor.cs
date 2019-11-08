using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class VolunteerDonor : Donor
    {
        [Key]
        public int Id { get; set; }
        public string? Company { get; set; }
        public string Offerings { get; set; }
    }
}