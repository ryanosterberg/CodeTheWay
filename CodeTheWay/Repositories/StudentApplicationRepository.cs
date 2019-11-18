using CodeTheWay.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeTheWay.Repositories
{
    public class StudentApplicationRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<StudentApplication> GetAllStudentApplications()
        {
            return db.StudentApplications.ToList();
        }

        public StudentApplication GetStudentApplicationById(int id)
        {
            return db.StudentApplications.Find(id);
        }

        public void Add(StudentApplication toAdd)
        {
            db.StudentApplications.Add(toAdd);
            db.SaveChanges();
        }

        public void Delete(StudentApplication toDelete)
        {
            db.StudentApplications.Remove(toDelete);
            db.SaveChanges();
        }

        public void Edit(StudentApplication toEdit)
        {
            db.Entry(toEdit).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}