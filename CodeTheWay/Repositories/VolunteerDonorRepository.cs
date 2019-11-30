using CodeTheWay.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeTheWay.Repositories
{
    public class VolunteerDonorRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<VolunteerDonor> GetAllVolunteerDonors()
        {
            return db.VolunteerDonors.ToList();
        }

        public VolunteerDonor GetVolunteerDonorById(int id)
        {
            return db.VolunteerDonors.Find(id);
        }

        public void Add(VolunteerDonor toAdd)
        {
            db.VolunteerDonors.Add(toAdd);
            db.SaveChanges();
        }

        public void Delete(VolunteerDonor toDelete)
        {
            db.VolunteerDonors.Remove(toDelete);
            db.SaveChanges();
        }

        public void Edit(VolunteerDonor toEdit)
        {
            db.Entry(toEdit).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}