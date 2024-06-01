using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services.Users
{
    public class UserSqlServerService : IUserReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();
        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
