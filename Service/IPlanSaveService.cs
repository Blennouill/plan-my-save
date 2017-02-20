using PlanMySave.Model;
using PlanMySave.Model.FinancialParameter;

namespace PlanMySave.Service
{
    public interface IPlanSaveService
    {
        Money GetDifferencialWithRevenuAndExpense(Revenu pRevenu, Expense pExpense);
    }
}