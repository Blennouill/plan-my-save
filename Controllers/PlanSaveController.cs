using Microsoft.AspNetCore.Mvc;
using PlanMySave.Model;
using PlanMySave.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanMySave.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlanSaveController : Controller
    {
        private readonly IPlanSaveService PlanSaveService;

        public PlanSaveController(IPlanSaveService planSaveService)
        {
            PlanSaveService = planSaveService;
        }

        // POST api/v{version}/planSave
        [HttpPost]
        public IActionResult Post([FromBody]PlanSaveInformation value)
        {
            //>Declaration
            PlanSaveResult lPlanSaveResult = new PlanSaveResult();
            //>Check
            if (value == null) { return BadRequest(); }
            //>Processing
            lPlanSaveResult.Money = PlanSaveService.GetDifferencialWithRevenuAndExpense(value.RevenuList.FirstOrDefault(), value.ExpenseList.FirstOrDefault());
            //>Return
            return new ObjectResult(lPlanSaveResult);
        }
    }
}
