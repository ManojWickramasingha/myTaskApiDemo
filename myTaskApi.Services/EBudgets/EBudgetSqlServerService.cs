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
        public List<EBudget> GetAllBudget(int userId)
        {
            return _context.EBudgets.Where(b => b.UserId == userId).ToList();
        }

        public EBudget GetBudget(int userId,String id)
        {
            return _context.EBudgets.FirstOrDefault(b => b.id == id && b.UserId == userId);
        }
    }
}
