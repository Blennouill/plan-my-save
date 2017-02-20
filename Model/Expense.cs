using PlanMySave.Library.Interface;
using PlanMySave.Model.FinancialParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Model
{
    public class Expense : IEntity
    {
        public int Id { get; set; }

        public Money Money { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Expense()
        {
            Money = new Money();
        }
    }
}
