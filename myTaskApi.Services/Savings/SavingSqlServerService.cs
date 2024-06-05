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
        public List<Saving> GetAllSaving(int userId)
        {
            return _context.Savings.Where(e => e.UserId == userId).ToList();
        }

        public Saving GetSaving(int userId,int id)
        {
            return _context.Savings.FirstOrDefault(e => e.Id == id && e.UserId == userId);
        }
    }
}
