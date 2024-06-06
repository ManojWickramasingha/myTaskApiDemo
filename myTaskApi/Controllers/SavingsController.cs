using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTaskApi.Services.Savings;
using AutoMapper;
using myTaskApi.Services.ViewModels;

namespace myTaskApi.Controllers
{
    [Route("api/users/{userId}/savings")]
    [ApiController]
    public class SavingsController : ControllerBase
    {
        private readonly ISavingReposatory _savingService;
        private readonly IMapper _mapper;
        public SavingsController(ISavingReposatory service, IMapper mapper)
        {
            _savingService = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<SavingDTO>> GetSavings(int userId)
        {
            var savings = _savingService.GetAllSaving(userId);
            var mapsavings = _mapper.Map<ICollection<SavingDTO>>(savings);
            return Ok(mapsavings);
        }

        [HttpGet("{id}")]
        public ActionResult<SavingDTO> GetSaving(int userId,int id)
        {
            var saving = _savingService.GetSaving(userId,id);
            if(saving is null)
            {
                return NotFound();
            }
            var mapsaving = _mapper.Map<SavingDTO>(saving);
            return Ok(mapsaving);
        }
    }
}
