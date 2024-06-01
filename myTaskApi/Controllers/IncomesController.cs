using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Incomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/incomes")]
    [ApiController]
    public class IncomesController : ControllerBase
    {

        private readonly IIncomeReposatory _incomeservices;

        public IncomesController(IIncomeReposatory service)
        {
            _incomeservices = service;
        }

        [HttpGet]
        public IActionResult GetAllIncomes()
        {
            var incomes = _incomeservices.GetAllIncomes();
            return Ok(incomes);
        }

        [HttpGet("{id}")]
        public IActionResult GetIncome(String id)
        {
            var income = _incomeservices.GetIncome(id);
            if(income is null)
            {
                return NotFound();
            }
            return Ok(income);
        }
    }
}
