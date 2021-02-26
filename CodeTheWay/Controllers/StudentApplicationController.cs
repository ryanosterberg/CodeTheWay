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
    [Authorize(Roles = "")]
    public class StudentApplicationController : BaseController
    {
        private StudentApplicationService service = new StudentApplicationService();
        // GET: StudentApplication
        public ActionResult Index()
        {
            return View(service.GetAllStudentApplications());
        }
        // GET: StudentApplication/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentApplication studentApplication = service.GetStudentApplicationById((int)id);
            if (studentApplication == null)
            {
                return HttpNotFound();
            }
            return View(studentApplication);
        }

        // GET: StudentApplication/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentApplication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> Create([Bind(Include = "Id,FirstName,LastName,Email,HighSchool,EstGradDate,WindowsLaptop,CSAComplete,Accomplishments,PresentAllClassDates,MissedClassDates,PresentAllSeasonDates,MissedSeasonDates")] StudentApplication studentApplication)
        {
            if (ModelState.IsValid)
            {
                service.Add(studentApplication);
                String text = "Hello " + studentApplication.FirstName + ", <br/><br/> Thank you for applying to help at Code the Way. If you have any questions, please contact us at: www.codetheway.org/Home/Contact";
                String subject = "Thank You for Signing Up for Code the Way!";
                String name = studentApplication.FirstName + " " + studentApplication.LastName;
                await Email(name, studentApplication.Email, text, subject);
                await AdminEmail(studentApplication);
                return RedirectToAction("Index", "Home");
            }

            return View(studentApplication);
        }

        // GET: StudentApplication/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentApplication studentApplication = service.GetStudentApplicationById((int)id);
            if (studentApplication == null)
            {
                return HttpNotFound();
            }
            return View(studentApplication);
        }

        // POST: StudentApplication/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,HighSchool,EstGradDate,WindowsLaptop,CSAComplete,Accomplishments,PresentAllClassDates,MissedClassDates,PresentAllSeasonDates,MissedSeasonDates")] StudentApplication studentApplication)
        {
            if (ModelState.IsValid)
            {
                service.Edit(studentApplication);
                return RedirectToAction("Index");
            }
            return View(studentApplication);
        }

        // GET: StudentApplication/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentApplication studentApplication = service.GetStudentApplicationById((int)id);
            if (studentApplication == null)
            {
                return HttpNotFound();
            }
            return View(studentApplication);
        }

        // POST: StudentApplication/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            service.Delete(service.GetStudentApplicationById(id));
            return RedirectToAction("Index");
        }
    }
}
