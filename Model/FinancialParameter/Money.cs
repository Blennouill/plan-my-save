using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Model.FinancialParameter
{
    public class Money
    {
        public int IdCurrency { get; set; }

        [JsonIgnore]
        public virtual Currency Currency { get; set; }
        public decimal Amount { get; set; }

        public Money()
        {
            Amount = decimal.Zero;
        }
    }
}
