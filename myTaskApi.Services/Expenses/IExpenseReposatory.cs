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
        public List<Expense> AllExpenses();
        //public Expense GetExpense(int id);
    }
}
