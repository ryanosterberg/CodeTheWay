using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using CodeTheWay.Models;
using CodeTheWay.Services;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace CodeTheWay.Controllers
{
    public class BaseController : Controller
    {
        private const string from_address = "r.osterberg@codetheway.org"; //Contact Adam Miller if you need to change this while keeping the rest of the SendGrid API stuff
        private const string admin_Student_Address = "r.osterberg@sodetheway.org";
        // private const string admin_Student_Address = "r.osterberg@sodetheway.org";
        private const string admin_Student_Name = "Ryan";
        private const string admin_NPO_Address = "22millea1@elmbrookstudents.org";
        // private const string admin_NPO_Address = b.zepecki@codetheway.org";
        private const string admin_NPO_Name = "Brad";
        private const string admin_Volunteer_Address = "22millea1@elmbrookstudents.org";
        // private const string admin_Volunteer_Address = "b.zepecki@codetheway.org";
        private const string admin_Volunteer_Name = "Brad";
        public async Task Email(String name, String address, String text, String subject)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(address, name);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(StudentApplication student)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_Student_Address, admin_Student_Name);
            String subject = "New Applicant";
            String text = "Hello " + admin_Student_Name + ", <br> A New Student has Applied: <br><br> Name: " + student.FirstName + " " + student.LastName + "<br> School: " + student.HighSchool;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }

        //Is FacilitiesTechDonor actually used?
        //public async Task AdminEmail(FacilitiesTechDonor ftd)
        //{
        //    var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress(from_address, "Code The Way");
        //    var to = new EmailAddress(admin, admin_name);
        //    String subject = "New Applicant";
        //    String text = "Hello " + admin_name + ", <br> A Facilities Tech Donor has sent a request: <br><br> Name: " + ftd.FirstName + " " + ftd.LastName + "<br> Company: " + ftd.Company;
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
        //    var response = await client.SendEmailAsync(msg);
        //}


        //To be Replaced
        public async Task AdminEmail(FinancialDonor fd)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress("22millea1@elmbrookstudents.org", "Ryan");
            String subject = "New Applicant";
            String text = "Hello Ryan, <br> A donation request has come in: <br><br> Name: " + fd.FirstName + " " + fd.LastName;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(NPOApplication npo)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_NPO_Address, admin_NPO_Name);
            String subject = "New Applicant";
            String text = "Hello " + admin_NPO_Name + ", <br> A NPO has sent a request: <br><br> Name: " + npo.ApplicantFirstName + " " + npo.ApplicantLastName + "<br> NPO: " + npo.OrgName;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(VolunteerDonor vd)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_Volunteer_Address, admin_Volunteer_Name);
            String subject = "New Applicant";
            String text = "Hello " + admin_Volunteer_Name + ", <br> A volunteer has requested to help: <br><br> Name: " + vd.FirstName + " " + vd.LastName + "<br> Company: " + vd.Company;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
    }
}