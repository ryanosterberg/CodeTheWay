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
    public class NPOApplicationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NPOApplication
        public ActionResult Index()
        {
            return View(db.NPOApplications.ToList());
        }

        // GET: NPOApplication/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPOApplication nPOApplication = db.NPOApplications.Find(id);
            if (nPOApplication == null)
            {
                return HttpNotFound();
            }
            return View(nPOApplication);
        }

        // GET: NPOApplication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NPOApplication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,OrgName,Email,PhoneNum,Address,ApplicantFirstName,ApplicantLastName,ApplicantPosition,ApplicantEmail,ApplicantPhone,NPOMission,NPOVision,WebURL,ProblemsAndDesires")] NPOApplication nPOApplication)
        {
            if (ModelState.IsValid)
            {
                db.NPOApplications.Add(nPOApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nPOApplication);
        }

        // GET: NPOApplication/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPOApplication nPOApplication = db.NPOApplications.Find(id);
            if (nPOApplication == null)
            {
                return HttpNotFound();
            }
            return View(nPOApplication);
        }

        // POST: NPOApplication/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,OrgName,Email,PhoneNum,Address,ApplicantFirstName,ApplicantLastName,ApplicantPosition,ApplicantEmail,ApplicantPhone,NPOMission,NPOVision,WebURL,ProblemsAndDesires")] NPOApplication nPOApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nPOApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nPOApplication);
        }

        // GET: NPOApplication/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPOApplication nPOApplication = db.NPOApplications.Find(id);
            if (nPOApplication == null)
            {
                return HttpNotFound();
            }
            return View(nPOApplication);
        }

        // POST: NPOApplication/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NPOApplication nPOApplication = db.NPOApplications.Find(id);
            db.NPOApplications.Remove(nPOApplication);
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
