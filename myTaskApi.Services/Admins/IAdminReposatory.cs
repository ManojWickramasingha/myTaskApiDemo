using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Admins
{
   public interface IAdminReposatory
    {
        public List<Admin> GetAllAdmins();
        public Admin GetAdmin(int id);
       
    }
}
