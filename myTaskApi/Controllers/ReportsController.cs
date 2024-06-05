using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportReposatory _reportService;
        public ReportsController(IReportReposatory service)
        {
            _reportService = service;
        }
        [HttpGet]
        public IActionResult GetReports()
        {
            var reports = _reportService.GetAllReport();
            return Ok(reports);
        }
        [HttpGet("{id}")]
        public IActionResult GetReport(int id)
        {
            var report = _reportService.GetAllReport();
            return Ok(report);
        }
    }
}
