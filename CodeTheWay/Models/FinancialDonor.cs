using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeTheWay.Models
{
    public class FinancialDonor
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

        /// <summary>
        /// An enum that represents how often payments are scheduled.
        /// </summary>
        public enum Frequency { BIANNUAL, WEEKLY, MONTHLY, YEARLY, ONCE }

        [DisplayName("Estimated Amount")]
        [Required]
        public double EstAmt { get; set; }

        public Frequency CurrentFrequency { get; set; }
    }
}