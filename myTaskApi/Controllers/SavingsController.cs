using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTaskApi.Services.Savings;

namespace myTaskApi.Controllers
{
    [Route("api/savings")]
    [ApiController]
    public class SavingsController : ControllerBase
    {
        private readonly ISavingReposatory _savingService;

        public SavingsController(ISavingReposatory service)
        {
            _savingService = service;
        }

        [HttpGet]
        public IActionResult GetSavings()
        {
            var savings = _savingService.GetAllSaving();
            return Ok(savings);
        }

        [HttpGet("{id}")]
        public IActionResult GetSaving(int id)
        {
            var saving = _savingService.GetSaving(id);
            if(saving is null)
            {
                return NotFound();
            }
            return Ok(saving);
        }
    }
}
