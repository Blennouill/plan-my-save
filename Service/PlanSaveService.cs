using PlanMySave.Library.Enumeration;
using PlanMySave.Model;
using PlanMySave.Model.FinancialParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Service
{
    public class PlanSaveService : IPlanSaveService
    {
        public PlanSaveService() { }

        /// <summary>
        /// Used for getting the result of the soustraction between revenu and expense.
        /// </summary>
        /// <param name="pRevenu"></param>
        /// <param name="pExpense"></param>
        /// <returns></returns>
        public Money GetDifferencialWithRevenuAndExpense(Revenu pRevenu, Expense pExpense)
        {
            //>Declaration
            decimal lResult = decimal.Zero;
            Money lMoney;

            //>Processing
            lResult = pRevenu.Money.Amount - pExpense.Money.Amount;
            lMoney = new Money { Amount = lResult, IdCurrency = (int)ENUMCurrencyType.Euro };

            //->Return
            return lMoney;
        }
    }
}
