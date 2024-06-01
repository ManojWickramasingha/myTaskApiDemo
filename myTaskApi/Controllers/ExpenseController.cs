using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Expenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/expenses")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        
        private IExpenseReposatory _expenseServices; 

        public ExpenseController(IExpenseReposatory reposatory)
        {
            _expenseServices =reposatory;
        }
        [HttpGet]
        public IActionResult AllExpenses ()
        {
            var myExpenses = _expenseServices.AllExpenses();
            return Ok(myExpenses);
            
        }

        [HttpGet("{id}")]
        public IActionResult GetExpense(int id)
        {
            var expense = _expenseServices.GetExpense(id);
            if(expense is null)
            {
                return NotFound();
            }
            return Ok(expense);
        }

     
        //get todos----
       
    }
}
