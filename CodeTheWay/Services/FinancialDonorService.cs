using CodeTheWay.Models;
using CodeTheWay.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTheWay.Services
{
    public class FinancialDonorService
    {
        private FinancialDonorRepository repo = new FinancialDonorRepository();
        public List<FinancialDonor> GetAllFinancialDonors()
        {
            return repo.GetAllFinancialDonors();
        }

        public FinancialDonor GetFinancialDonorsById(int id)
        {
            return repo.GetFinancialDonorById(id);
        }

        public void Add(FinancialDonor toAdd)
        {
            repo.Add(toAdd);
        }

        public void Delete(FinancialDonor toDelete)
        {
            repo.Delete(toDelete);
        }

        public void Edit(FinancialDonor toEdit)
        {
            repo.Edit(toEdit);
        }
    }
}