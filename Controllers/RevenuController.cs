using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanMySave.Model;
using PlanMySave.Service;

namespace PlanMySave.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}[controller]")]
    public class RevenuController : Controller
    {
        private readonly IRevenuService RevenuService;

        public RevenuController(IRevenuService revenuService)
        {
            RevenuService = revenuService;
        }

        // GET api/revenu
        [HttpGet]
        public IEnumerable<Revenu> Get()
        {
            return RevenuService.GetAll();
        }

        // GET api/revenu/5
        [HttpGet("{id}")]
        public Revenu Get(int id)
        {
            return RevenuService.GetByID(id);
        }

        // POST api/revenu
        [HttpPost]
        public IActionResult Post([FromBody]Revenu revenu)
        {
            //>Check
            if (revenu == null) { return BadRequest(); }

            RevenuService.Create(revenu);

            //>Return
            return new ObjectResult(revenu);
        }

        // PUT api/revenu/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/revenu/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}