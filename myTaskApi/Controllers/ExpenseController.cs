using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Expenses;
using myTaskApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/users/{userId}/expenses")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        
        private readonly IExpenseReposatory _expenseServices;
        private readonly IMapper _mapper;
        public ExpenseController(IExpenseReposatory reposatory,IMapper mapper)
        {
            _expenseServices =reposatory;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<ExpenseDTO>> AllExpenses (int userId)
        {
            var myExpenses = _expenseServices.AllExpenses(userId);
            var mapExpenses = _mapper.Map<ICollection<ExpenseDTO>>(myExpenses);
            return Ok(mapExpenses);
            
        }

        [HttpGet("{id}")]
        public IActionResult GetExpense(int userId,int id)
        {
            var expense = _expenseServices.GetExpense(userId,id);
            if(expense is null)
            {
                return NotFound();
            }
            var mapExpense = _mapper.Map<ExpenseDTO>(expense);
            return Ok(mapExpense);
        }

     
        //get todos----
       
    }
}
