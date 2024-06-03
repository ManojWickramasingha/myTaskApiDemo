using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myTaskApi.Services.Incomes
{
    public interface IIncomeReposatory
    {
     
        public List<Income> GetAllIncomes(int userId);
        public Income GetIncome(int userId,String id);
    }
}
