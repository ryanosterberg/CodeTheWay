using CodeTheWay.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeTheWay.Repositories
{
    public class FacilitiesTechDonorRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<FacilitiesTechDonor> GetAllFacilitiesTechDonors()
        {
            return db.FacilitiesTechDonors.ToList();
        }

        public FacilitiesTechDonor GetFacilitiesTechDonorById(int id)
        {
            return db.FacilitiesTechDonors.Find(id);
        }

        public void Add(FacilitiesTechDonor toAdd)
        {
            db.FacilitiesTechDonors.Add(toAdd);
            db.SaveChanges();
        }

        public void Delete(FacilitiesTechDonor toDelete)
        {
            db.FacilitiesTechDonors.Remove(toDelete);
            db.SaveChanges();
        }

        public void Edit(FacilitiesTechDonor toEdit)
        {
            db.Entry(toEdit).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}