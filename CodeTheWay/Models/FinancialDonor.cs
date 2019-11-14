using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class FinancialDonor
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// An enum that represents how often payments are scheduled.
        /// </summary>
        public enum Frequency { BIANNUAL, WEEKLY, MONTHLY, YEARLY, ONCE }
        public double EstAmt { get; set; }
        public Frequency CurrentFrequency { get; set; }
    }
}