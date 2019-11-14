using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeTheWay.Models;

namespace CodeTheWay.Controllers
{
    public class StudentApplicationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentApplication
        public ActionResult Index()
        {
            return View(db.StudentApplications.ToList());
        }

        // GET: StudentApplication/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentApplication studentApplication = db.StudentApplications.Find(id);
            if (studentApplication == null)
            {
                return HttpNotFound();
            }
            return View(studentApplication);
        }

        // GET: StudentApplication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentApplication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,HighSchool,EstGradDate,WindowsLaptop,CSAComplete,Accomplishments,PresentAllClassDates,MissedClassDates,PresentAllSeasonDates,MissedSeasonDates")] StudentApplication studentApplication)
        {
            if (ModelState.IsValid)
            {
                db.StudentApplications.Add(studentApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentApplication);
        }

        // GET: StudentApplication/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentApplication studentApplication = db.StudentApplications.Find(id);
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
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,HighSchool,EstGradDate,WindowsLaptop,CSAComplete,Accomplishments,PresentAllClassDates,MissedClassDates,PresentAllSeasonDates,MissedSeasonDates")] StudentApplication studentApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentApplication);
        }

        // GET: StudentApplication/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentApplication studentApplication = db.StudentApplications.Find(id);
            if (studentApplication == null)
            {
                return HttpNotFound();
            }
            return View(studentApplication);
        }

        // POST: StudentApplication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentApplication studentApplication = db.StudentApplications.Find(id);
            db.StudentApplications.Remove(studentApplication);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
