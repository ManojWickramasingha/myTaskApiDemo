using myTaskApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services.Expenses
{  
    public class ExpenseSqlServerServices : IExpenseReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();

        public List<Expense> AllExpenses(int userId)
        {
            return _context.Expenses.Where(e => e.UserId == userId).ToList();
        }  

        public Expense GetExpense(int userId, int id)
        {
            return _context.Expenses.FirstOrDefault(e => e.id == id && e.UserId == userId);
        }
    }
}
