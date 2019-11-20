using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeTheWay.Models;
using CodeTheWay.Services;

namespace CodeTheWay.Controllers
{
    public class NPOApplicationController : Controller
    {
        private NPOApplicationService service = new NPOApplicationService();

        // GET: NPOApplication
        public ActionResult Index()
        {
            return View(service.GetNPOApplications());
        }

        // GET: NPOApplication/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NPOApplication nPOApplication = service.GetNPOApplicationById((int) id);
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
                service.Add(nPOApplication);
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
            NPOApplication nPOApplication = service.GetNPOApplicationById((int)id);
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
                service.Edit(nPOApplication);
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
            NPOApplication nPOApplication = service.GetNPOApplicationById((int)id);
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
            NPOApplication nPOApplication = service.GetNPOApplicationById((int)id);
            service.Delete(service.GetNPOApplicationById((int)id));
            return RedirectToAction("Index");
        }
    }
}
