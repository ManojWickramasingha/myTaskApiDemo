using myTaskApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Expenses
{
   public interface IExpenseReposatory
    {
        public List<Expense> AllExpenses(int userId);
        public Expense GetExpense(int userId, int id);
       
    }
}
