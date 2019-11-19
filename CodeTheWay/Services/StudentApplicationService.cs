using CodeTheWay.Models;
using CodeTheWay.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTheWay.Services
{
    public class StudentApplicationService
    {
        private StudentApplicationRepository repo = new StudentApplicationRepository();

        public List<StudentApplication> GetAllStudentApplications()
        {
            return repo.GetAllStudentApplications();
        }

        public StudentApplication GetStudentApplicationById(int id)
        {
            return repo.GetStudentApplicationById(id);
        }

        public void Add(StudentApplication toAdd)
        {
            repo.Add(toAdd);
        }

        public void Delete(StudentApplication toDelete)
        {
            repo.Delete(toDelete);
        }

        public void Edit(StudentApplication toEdit)
        {
            repo.Edit(toEdit);
        }
    }
}