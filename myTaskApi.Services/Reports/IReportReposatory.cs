using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Reports
{
    public interface IReportReposatory
    {
        public List<Report> GetAllReport();

        public Report GetReport(int id);
    }
}
