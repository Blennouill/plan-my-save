using PlanMySave.Library;
using PlanMySave.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Repository
{
    public class RevenuRepository : BaseRepository<Revenu>, IRevenuRepository
    {
        public RevenuRepository(PlanMySaveContext dbContext) : base(dbContext)
        {
        }
    }
}
