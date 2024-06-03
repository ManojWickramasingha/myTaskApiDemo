using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.EBudgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/ebudgets")]
    [ApiController]
    public class EBudgetsController : ControllerBase
    {
        private readonly IEBudgetReposatory  _Ebudgetservice;

        public EBudgetsController(IEBudgetReposatory service)
        {
            _Ebudgetservice = service; 
        }

        [HttpGet]
        public IActionResult GetBudgets()
        {
            var budgets = _Ebudgetservice.GetAllBudget();
            return Ok(budgets);
        }
        [HttpGet("{id}")]
        public IActionResult GetBudget(String id)
        {
            var budget = _Ebudgetservice.GetBudget(id);

            if(budget is null)
            {
                return NotFound();
            }
            return Ok(budget);
        }
    }
}
