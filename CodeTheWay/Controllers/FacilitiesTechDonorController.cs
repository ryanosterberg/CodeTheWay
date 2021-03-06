﻿using System;
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
    public class FacilitiesTechDonorController : Controller
    {
        private FacilitiesTechDonorService service = new FacilitiesTechDonorService();

        // GET: FacilitiesTechDonor
        [Authorize]
        public ActionResult Index()
        {
            return View(service.GetAllFacilitiesTechDonors());
        }

        // GET: FacilitiesTechDonor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilitiesTechDonor facilitiesTechDonor = service.GetFacilitiesTechDonorById((int)id);
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
                service.Add(facilitiesTechDonor);
                return RedirectToAction("Index");
            }

            return View(facilitiesTechDonor);
        }

        // GET: FacilitiesTechDonor/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilitiesTechDonor facilitiesTechDonor = service.GetFacilitiesTechDonorById((int)id);
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
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Company,Offerings")] FacilitiesTechDonor facilitiesTechDonor)
        {
            if (ModelState.IsValid)
            {
                service.Edit(facilitiesTechDonor);
                return RedirectToAction("Index");
            }
            return View(facilitiesTechDonor);
        }

        [Authorize]
        // GET: FacilitiesTechDonor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacilitiesTechDonor facilitiesTechDonor = service.GetFacilitiesTechDonorById((int)id);
            if (facilitiesTechDonor == null)
            {
                return HttpNotFound();
            }
            return View(facilitiesTechDonor);
        }

        [Authorize]
        // POST: FacilitiesTechDonor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            service.Delete(service.GetFacilitiesTechDonorById((int)id));
            return RedirectToAction("Index");
        }
    }
}
