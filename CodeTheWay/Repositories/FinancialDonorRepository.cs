using CodeTheWay.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeTheWay.Repositories
{
    public class FinancialDonorRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<FinancialDonor> GetAllFinancialDonors()
        {
            return db.FinancialDonors.ToList();
        }

        public FinancialDonor GetFinancialDonorById(int id)
        {
            return db.FinancialDonors.Find(id);
        }

        public void Add(FinancialDonor toAdd)
        {
            db.FinancialDonors.Add(toAdd);
            db.SaveChanges();
        }

        public void Delete(FinancialDonor toDelete)
        {
            db.FinancialDonors.Remove(toDelete);
            db.SaveChanges();
        }

        public void Edit(FinancialDonor toEdit)
        {
            db.Entry(toEdit).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}