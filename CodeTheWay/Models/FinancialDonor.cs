using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class FinancialDonor : Donor
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// An enum that represents how often payments are scheduled.
        /// </summary>
        public enum Frequency { BIANNUAL, WEEKLY, MONTHLY, YEARLY }
        public double EstAmt { get; set; }
        public Frequency CurrentFrequency { get; set; }
    }
}