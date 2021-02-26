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
        public const string from_address = "22millea1@elmbrookstudents.org";
        private const string admin_address = "22millea1@elmbrookstudents.org";
        private const string admin_name= "Ryan";

        public async Task Email(String name, String address, String text, String subject)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("22millea1@elmbrookstudents.org", "Code The Way");
            var to = new EmailAddress(address, name);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(StudentApplication student)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_address, admin_name);
            String subject = "New Applicant";
            String text = "Hello " + admin_name + ", <br> A New Student has Applied: <br><br> Name: " + student.FirstName + " " + student.LastName + "<br> School: " + student.HighSchool;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }

        //Is FacilitiesTechDonor actually used?
        public async Task AdminEmail(FacilitiesTechDonor ftd)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_address, admin_name);
            String subject = "New Applicant";
            String text = "Hello " + admin_name + ", <br> A Facilities Tech Donor has sent a request: <br><br> Name: " + ftd.FirstName + " " + ftd.LastName + "<br> Company: " + ftd.Company;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(FinancialDonor fd)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_address, admin_name);
            String subject = "New Applicant";
            String text = "Hello " + admin_name + ", <br> A donation request has come in: <br><br> Name: " + fd.FirstName + " " + fd.LastName;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(NPOApplication npo)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_address, admin_name);
            String subject = "New Applicant";
            String text = "Hello " + admin_name + ", <br> A NPO has sent a request: <br><br> Name: " + npo.ApplicantFirstName + " " + npo.ApplicantLastName + "<br> NPO: " + npo.OrgName;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
        public async Task AdminEmail(VolunteerDonor vd)
        {
            var apiKey = WebConfigurationManager.AppSettings["SendGridEnvironmentalKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(from_address, "Code The Way");
            var to = new EmailAddress(admin_address, admin_name);
            String subject = "New Applicant";
            String text = "Hello " + admin_name + ", <br> A volunteer has requested to help: <br><br> Name: " + vd.FirstName + " " + vd.LastName + "<br> Company: " + vd.Company;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, text, text);
            var response = await client.SendEmailAsync(msg);
        }
    }
}