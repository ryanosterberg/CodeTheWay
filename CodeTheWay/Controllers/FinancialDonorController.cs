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
    [Authorize(Roles = "")]
    public class FinancialDonorController : BaseController
    {
        private FinancialDonorService service = new FinancialDonorService();

        // GET: FinancialDonor
        public ActionResult Index()
        {
            return View(service.GetAllFinancialDonors());
        }

        // GET: FinancialDonor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDonor financialDonor = service.GetFinancialDonorById((int)id);
            if (financialDonor == null)
            {
                return HttpNotFound();
            }
            return View(financialDonor);
        }

        // GET: FinancialDonor/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinancialDonor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<ActionResult> Create([Bind(Include = "Id,FirstName,LastName,Email,EstAmt,CurrentFrequency")] FinancialDonor financialDonor)
        {
            if (ModelState.IsValid)
            {
                service.Add(financialDonor);
                String text = "Hello " + financialDonor.FirstName + ", <br/><br/> Thank you for donating to Code the Way. If you have any questions, please contact us at: www.codetheway.org/Home/Contact";
                String subject = "Thank You for Donating to Code the Way!";
                String name = financialDonor.FirstName + " " + financialDonor.LastName;
                await Email(name, financialDonor.Email, text, subject);
                await AdminEmail(financialDonor);
                return RedirectToAction("Index", "Home");
            }

            return View(financialDonor);
        }

        // GET: FinancialDonor/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDonor financialDonor = service.GetFinancialDonorById((int)id);
            if (financialDonor == null)
            {
                return HttpNotFound();
            }
            return View(financialDonor);
        }

        // POST: FinancialDonor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,EstAmt,CurrentFrequency")] FinancialDonor financialDonor)
        {
            if (ModelState.IsValid)
            {
                service.Edit(financialDonor);
                return RedirectToAction("Index");
            }
            return View(financialDonor);
        }

        // GET: FinancialDonor/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDonor financialDonor = service.GetFinancialDonorById((int)id);
            if (financialDonor == null)
            {
                return HttpNotFound();
            }
            return View(financialDonor);
        }

        // POST: FinancialDonor/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            service.Delete(service.GetFinancialDonorById(id));
            return RedirectToAction("Index");
        }
    }
}
