using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.EBudgets
{
    public interface IEBudgetReposatory
    {
        public List<EBudget> GetAllBudget(int userId);
        public EBudget GetBudget(int userId,String id);
    }
}
