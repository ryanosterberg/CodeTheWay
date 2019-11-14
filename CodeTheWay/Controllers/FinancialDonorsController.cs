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
    public class FinancialDonorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FinancialDonors
        public ActionResult Index()
        {
            return View(db.FinancialDonors.ToList());
        }

        // GET: FinancialDonors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDonor financialDonor = db.FinancialDonors.Find(id);
            if (financialDonor == null)
            {
                return HttpNotFound();
            }
            return View(financialDonor);
        }

        // GET: FinancialDonors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinancialDonors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,EstAmt,CurrentFrequency")] FinancialDonor financialDonor)
        {
            if (ModelState.IsValid)
            {
                db.FinancialDonors.Add(financialDonor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(financialDonor);
        }

        // GET: FinancialDonors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDonor financialDonor = db.FinancialDonors.Find(id);
            if (financialDonor == null)
            {
                return HttpNotFound();
            }
            return View(financialDonor);
        }

        // POST: FinancialDonors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,EstAmt,CurrentFrequency")] FinancialDonor financialDonor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(financialDonor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(financialDonor);
        }

        // GET: FinancialDonors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDonor financialDonor = db.FinancialDonors.Find(id);
            if (financialDonor == null)
            {
                return HttpNotFound();
            }
            return View(financialDonor);
        }

        // POST: FinancialDonors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FinancialDonor financialDonor = db.FinancialDonors.Find(id);
            db.FinancialDonors.Remove(financialDonor);
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
