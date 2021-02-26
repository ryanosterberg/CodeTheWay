using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CodeTheWay.Models;
using CodeTheWay.Services;

namespace CodeTheWay.Controllers
{
    [Authorize(Users = "")]
    public class NPOApplicationController : BaseController
    {
        private NPOApplicationService service = new NPOApplicationService();

        // GET: NPOApplication
        public ActionResult Index()
        {
            return View(service.GetAllNPOApplications());
        }

        // GET: NPOApplication/Details/5
        public ActionResult Details(int? id)
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

        // GET: NPOApplication/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: NPOApplication/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> Create([Bind(Include = "Id,OrgName,ApplicantFirstName,ApplicantLastName,ApplicantPosition,ApplicantEmail,ApplicantPhone,NPOMission,NPOVision,WebURL,ProblemsAndDesires")] NPOApplication nPOApplication)
        {
            if (ModelState.IsValid)
            {
                service.Add(nPOApplication);
                String text = "Hello " + nPOApplication.ApplicantFirstName + ", <br/>Thank you for applying to be a nonprofit partner of Code the Way.  Your mission, vision, and needs are extremely important to Code the Way.  A member of the Code the Way team will contact you within the next business week.<br><br>Brad Zepecki<br>b.zepecki@codetheway.org<br>Founder - Code the Way<br>President and Director of Octavian Technology";
                String subject = "Thank You for Coming to Code the Way!";
                String name = nPOApplication.ApplicantFirstName + " " + nPOApplication.ApplicantLastName;
                await Email(name, nPOApplication.ApplicantEmail, text, subject);
                await AdminEmail(nPOApplication);
                return RedirectToAction("Index", "Home");
            }

            return View(nPOApplication);
        }

        // GET: NPOApplication/Edit/5
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NPOApplication nPOApplication = service.GetNPOApplicationById((int)id);
            service.Delete(service.GetNPOApplicationById((int)id));
            return RedirectToAction("Index");
        }
    }
}
