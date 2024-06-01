using myTaskApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Services
{
    public class ExpenseServices : IExpenseReposatory
    {
      

        public List<Expense> AllExpenses()
        {
            var Expenses = new List<Expense>();

            var expense1 = new Expense
            {
                id = 1,
                title = "get book for school",
                Description = "Get some text books for school",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = ExpenseStatus.New,
                Amount = 3000.00
            };
            Expenses.Add(expense1);

            var expense2  = new Expense
            {
                id = 2,
                title = "get book for Library",
                Description = "Get some text books for Library",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                status = ExpenseStatus.completed,
                Amount = 3010.00
            };

            Expenses.Add(expense2);

            var expense3 = new Expense
            {
                id = 3,
                title = "get book for children",
                Description = "Get some text books for classroom",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                status = ExpenseStatus.inprgress,
                Amount = 3050.00
            };
            Expenses.Add(expense3);

            return Expenses;
        }
    }
}
