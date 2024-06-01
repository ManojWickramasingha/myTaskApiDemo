using myTaskApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services
{  
    public class ExpenseSqlServerServices : IExpenseReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();

        public List<Expense> AllExpenses()
        {
            return _context.Expenses.ToList();
        }  
    }
}
