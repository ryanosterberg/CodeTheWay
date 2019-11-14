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
    public class VolunteerDonorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VolunteerDonor
        public ActionResult Index()
        {
            return View(db.VolunteerDonors.ToList());
        }

        // GET: VolunteerDonor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerDonor volunteerDonor = db.VolunteerDonors.Find(id);
            if (volunteerDonor == null)
            {
                return HttpNotFound();
            }
            return View(volunteerDonor);
        }

        // GET: VolunteerDonor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VolunteerDonor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,Company,Offerings")] VolunteerDonor volunteerDonor)
        {
            if (ModelState.IsValid)
            {
                db.VolunteerDonors.Add(volunteerDonor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volunteerDonor);
        }

        // GET: VolunteerDonor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerDonor volunteerDonor = db.VolunteerDonors.Find(id);
            if (volunteerDonor == null)
            {
                return HttpNotFound();
            }
            return View(volunteerDonor);
        }

        // POST: VolunteerDonor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Company,Offerings")] VolunteerDonor volunteerDonor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteerDonor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volunteerDonor);
        }

        // GET: VolunteerDonor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerDonor volunteerDonor = db.VolunteerDonors.Find(id);
            if (volunteerDonor == null)
            {
                return HttpNotFound();
            }
            return View(volunteerDonor);
        }

        // POST: VolunteerDonor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VolunteerDonor volunteerDonor = db.VolunteerDonors.Find(id);
            db.VolunteerDonors.Remove(volunteerDonor);
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
