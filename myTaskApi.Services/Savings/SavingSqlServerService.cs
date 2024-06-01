using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services.Savings
{
    public class SavingSqlServerService : ISavingReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();
        public List<Saving> GetAllSaving()
        {
            return _context.Savings.ToList();
        }

        public Saving GetSaving(int id)
        {
            return _context.Savings.Find(id);
        }
    }
}
