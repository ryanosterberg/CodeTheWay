using CodeTheWay.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeTheWay.Repositories
{
    public class NPOApplicationRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<NPOApplication> GetAllNPOApplications()
        {
            return db.NPOApplications.ToList();
        }

        public NPOApplication GetNPOApplicationById(int id)
        {
            return db.NPOApplications.Find(id);
        }

        public void Add(NPOApplication toAdd)
        {
            db.NPOApplications.Add(toAdd);
            db.SaveChanges();
        }

        public void Delete(NPOApplication toDelete)
        {
            db.NPOApplications.Remove(toDelete);
            db.SaveChanges();
        }

        public void Edit(NPOApplication toEdit)
        {
            db.Entry(toEdit).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}