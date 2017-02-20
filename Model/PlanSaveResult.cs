using PlanMySave.Model.FinancialParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Model
{
    public class PlanSaveResult
    {
        public Money Money { get; set; }

        public PlanSaveResult()
        {
            Money = new Money();
        }

    }
}
