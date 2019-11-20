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
    public class FacilitiesTechDonorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FacilitiesTechDonor
        public ActionResult Index()
        {
            return View(db.FacilitiesTechDonors.ToList());
        }

        // GET: FacilitiesTechDonor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilitiesTechDonor facilitiesTechDonor = db.FacilitiesTechDonors.Find(id);
            if (facilitiesTechDonor == null)
            {
                return HttpNotFound();
            }
            return View(facilitiesTechDonor);
        }

        // GET: FacilitiesTechDonor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacilitiesTechDonor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,Company,Offerings")] FacilitiesTechDonor facilitiesTechDonor)
        {
            if (ModelState.IsValid)
            {
                db.FacilitiesTechDonors.Add(facilitiesTechDonor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilitiesTechDonor);
        }

        // GET: FacilitiesTechDonor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilitiesTechDonor facilitiesTechDonor = db.FacilitiesTechDonors.Find(id);
            if (facilitiesTechDonor == null)
            {
                return HttpNotFound();
            }
            return View(facilitiesTechDonor);
        }

        // POST: FacilitiesTechDonor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Company,Offerings")] FacilitiesTechDonor facilitiesTechDonor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilitiesTechDonor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilitiesTechDonor);
        }

        // GET: FacilitiesTechDonor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilitiesTechDonor facilitiesTechDonor = db.FacilitiesTechDonors.Find(id);
            if (facilitiesTechDonor == null)
            {
                return HttpNotFound();
            }
            return View(facilitiesTechDonor);
        }

        // POST: FacilitiesTechDonor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacilitiesTechDonor facilitiesTechDonor = db.FacilitiesTechDonors.Find(id);
            db.FacilitiesTechDonors.Remove(facilitiesTechDonor);
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
