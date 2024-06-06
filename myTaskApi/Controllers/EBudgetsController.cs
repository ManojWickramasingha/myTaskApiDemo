using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.EBudgets;
using myTaskApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/user/{userId}/ebudgets")]
    [ApiController]
    public class EBudgetsController : ControllerBase
    {
        private readonly IEBudgetReposatory  _Ebudgetservice;
        private readonly IMapper _mapper;
        public EBudgetsController(IEBudgetReposatory service,IMapper mappper)
        {
            _Ebudgetservice = service;
            _mapper = mappper;
        }

        [HttpGet]
        public IActionResult GetBudgets(int userId)
        {
            var budgets = _Ebudgetservice.GetAllBudget(userId);
            var mapbudgets = _mapper.Map<ICollection<EBudgetDTO>>(budgets);
            return Ok(mapbudgets);
        }
        [HttpGet("{id}")]
        public IActionResult GetBudget(int userId,String id)
        {
            var budget = _Ebudgetservice.GetBudget(userId,id);

            if(budget is null)
            {
                return NotFound();
            }
            var mapbudget = _mapper.Map<EBudgetDTO>(budget);
            return Ok(mapbudget);
        }
    }
}
