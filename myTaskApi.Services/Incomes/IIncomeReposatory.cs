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
     
        public List<Income> GetAllIncomes();
        public Income GetIncome(String id);
    }
}
