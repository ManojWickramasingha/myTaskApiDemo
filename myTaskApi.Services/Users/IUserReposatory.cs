using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.Users
{
    public interface IUserReposatory
    {
        public List<User> GetAllUser();
        public User GetUser(int id);
    }
}
