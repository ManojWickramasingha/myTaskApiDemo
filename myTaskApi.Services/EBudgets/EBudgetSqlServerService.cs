using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services.EBudgets
{
    public class EBudgetSqlServerService : IEBudgetReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();
        public List<EBudget> GetAllBudget()
        {
            return _context.EBudgets.ToList();
        }

        public EBudget GetBudget(String id)
        {
            return _context.EBudgets.Find(id);
        }
    }
}
