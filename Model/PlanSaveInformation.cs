using PlanMySave.Library.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Model
{
    public class PlanSaveInformation
    {
        public IList<Revenu> RevenuList { get; set; }
        public IList<Expense> ExpenseList { get; set; }
        public int Duration { get; set; }
        public ENUMDurationType DurationType { get; set; }
    }
}
