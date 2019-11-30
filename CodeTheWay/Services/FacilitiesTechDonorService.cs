using CodeTheWay.Models;
using CodeTheWay.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTheWay.Services
{
    public class FacilitiesTechDonorService
    {
        private FacilitiesTechDonorRepository repo = new FacilitiesTechDonorRepository();
        public List<FacilitiesTechDonor> GetAllFacilitiesTechDonors()
        {
            return repo.GetAllFacilitiesTechDonors();
        }

        public FacilitiesTechDonor GetFacilitiesTechDonorById(int id)
        {
            return repo.GetFacilitiesTechDonorById(id);
        }

        public void Add(FacilitiesTechDonor toAdd)
        {
            repo.Add(toAdd);
        }

        public void Delete(FacilitiesTechDonor toDelete)
        {
            repo.Delete(toDelete);
        }

        public void Edit(FacilitiesTechDonor toEdit)
        {
            repo.Edit(toEdit);
        }
    }
}