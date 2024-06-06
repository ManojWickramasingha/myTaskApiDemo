
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Incomes;
using myTaskApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/users/{userId}/incomes")]
    [ApiController]
    public class IncomesController : ControllerBase
    {

        private readonly IIncomeReposatory _incomeservices;
        private readonly IMapper _mapper;
        public IncomesController(IIncomeReposatory service, IMapper mapper)
        {
            _incomeservices = service;
            _mapper = mapper;
           
        }

        [HttpGet]
        public ActionResult<ICollection<IncomeDTO>> GetAllIncomes(int userId)
        {
            var incomes = _incomeservices.GetAllIncomes(userId);
            var mapincomes = _mapper.Map<ICollection<IncomeDTO>>(incomes); 
            return Ok(mapincomes);
        }

        [HttpGet("{id}")]
        public ActionResult<IncomeDTO> GetIncome(int userId, String id)
        {
            var income = _incomeservices.GetIncome(userId,id);
            if(income is null)
            {
                return NotFound();
            }
            var mapincome = _mapper.Map<IncomeDTO>(income);
            return Ok(mapincome);
        }
    }
}
