using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Gmail { get; set; }
        public String Password { get; set; }
    }
}
