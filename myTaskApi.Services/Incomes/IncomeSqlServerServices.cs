using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services.Incomes
{
    public class IncomeSqlServerServices : IIncomeReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();
        public List<Income> GetAllIncomes()
        {
            return _context.Incomes.ToList();
        }

        public Income GetIncome(String id)
        {
            return _context.Incomes.Find(id);
        }
    }
}
