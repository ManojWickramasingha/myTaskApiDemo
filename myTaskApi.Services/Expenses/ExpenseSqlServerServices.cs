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
            return _context.Expenses.Where(i => i.UserId == userId).ToList();
        }  

        public Expense GetExpense( int Id)
        {
            return _context.Expenses.Find(Id);
        }
    }
}
