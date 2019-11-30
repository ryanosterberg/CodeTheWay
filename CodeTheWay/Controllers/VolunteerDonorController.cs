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
    public class VolunteerDonorController : Controller
    {
        private VolunteerDonorService service = new VolunteerDonorService();

        // GET: VolunteerDonor
        public ActionResult Index()
        {
            return View(service.GetAllVolunteerDonors());
        }

        // GET: VolunteerDonor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VolunteerDonor volunteerDonor = service.GetVolunteerDonorById((int)id);
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
                service.Add(volunteerDonor);
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
            VolunteerDonor volunteerDonor = service.GetVolunteerDonorById((int)id);
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
                service.Edit(volunteerDonor);
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
            VolunteerDonor volunteerDonor = service.GetVolunteerDonorById((int)id);
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
            service.Delete(service.GetVolunteerDonorById((int)id));
            return RedirectToAction("Index");
        }
    }
}
