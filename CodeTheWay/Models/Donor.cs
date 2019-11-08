using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public abstract class Donor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}