using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class Income
    {
        public String Id { get; set; }
        public double Amount { get; set; }
        public String Categories { get; set; }

        public String description { get; set; }
        public DateTime start { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
