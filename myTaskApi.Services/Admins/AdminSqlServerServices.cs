using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myTaskApi.DataAccess;

namespace myTaskApi.Services.Admins
{
    public class AdminSqlServerServices : IAdminReposatory
    {
        private readonly ExpenseDbContext _context = new ExpenseDbContext();
       
        public Admin GetAdmin(int id)
        {
            return _context.Admins.Find(id);

        }

       
        public List<Admin> GetAllAdmins()
        {
            return _context.Admins.ToList();
        }
    }
}
