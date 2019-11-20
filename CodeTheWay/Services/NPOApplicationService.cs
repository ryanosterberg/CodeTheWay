using CodeTheWay.Models;
using CodeTheWay.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTheWay.Services
{
    public class NPOApplicationService
    {
        private NPOApplicationRepository repo = new NPOApplicationRepository();
        public List<NPOApplication> GetAllNPOApplications()
        {
            return repo.GetAllNPOApplications();
        }

        public NPOApplication GetNPOApplicationById(int id)
        {
            return repo.GetNPOApplicationById(id);
        }

        public void Add(NPOApplication toAdd)
        {
            repo.Add(toAdd);
        }

        public void Delete(NPOApplication toDelete)
        {
            repo.Delete(toDelete);
        }

        public void Edit(NPOApplication toEdit)
        {
            repo.Edit(toEdit);
        }
    }
}