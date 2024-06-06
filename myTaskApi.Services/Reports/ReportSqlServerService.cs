using myTaskApi.DataAccess;
using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Reports
{
    public class ReportSqlServerService : IReportReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();
       
        public List<Report> GetAllReport()
        {
            return _context.Reports.ToList();
        }

        public Report GetReport(int id)
        {
            return _context.Reports.Find(id);
        }
    }
}
