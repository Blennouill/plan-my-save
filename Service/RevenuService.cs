using PlanMySave.Library;
using PlanMySave.Model;
using PlanMySave.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Service
{
    public class RevenuService : BaseServiceRepository<Revenu>, IRevenuService
    {
        public RevenuService(RevenuRepository repository) : base(repository)
        {
        }

    }
}
