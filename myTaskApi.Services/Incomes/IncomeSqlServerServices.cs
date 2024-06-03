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
        public List<Income> GetAllIncomes(int userId)
        {
            return _context.Incomes.Where(i => i.UserId == userId).ToList();
        }

        public Income GetIncome(int userId, string id)
        {
            return _context.Incomes.FirstOrDefault(i => i.Id == id && i.UserId == userId);
        }
    }
}
