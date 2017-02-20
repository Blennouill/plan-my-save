using PlanMySave.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Model.FinancialParameter
{
    public class Currency : IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Format { get; set; }
    }
}
