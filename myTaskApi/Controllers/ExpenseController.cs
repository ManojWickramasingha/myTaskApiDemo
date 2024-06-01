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
        [HttpGet("{id?}")]
       public IActionResult expenses(int? id)
        {
            var myExpenses = _expenseServices.AllExpenses();

            if (id is null) return Ok(myExpenses);

            myExpenses = myExpenses.Where(t => t.id == id).ToList();

            return Ok(myExpenses);
            
        }

     
        //get todos----
       
    }
}
