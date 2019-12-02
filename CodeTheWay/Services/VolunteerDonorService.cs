using CodeTheWay.Models;
using CodeTheWay.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTheWay.Services
{
    public class VolunteerDonorService
    {
        private VolunteerDonorRepository repo = new VolunteerDonorRepository();
        public List<VolunteerDonor> GetAllVolunteerDonors()
        {
            return repo.GetAllVolunteerDonors();
        }

        public VolunteerDonor GetVolunteerDonorById(int id)
        {
            return repo.GetVolunteerDonorById(id);
        }

        public void Add(VolunteerDonor toAdd)
        {
            repo.Add(toAdd);
        }

        public void Delete(VolunteerDonor toDelete)
        {
            repo.Delete(toDelete);
        }

        public void Edit(VolunteerDonor toEdit)
        {
            repo.Edit(toEdit);
        }
    }
}