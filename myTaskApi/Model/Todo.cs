using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Model
{
    public class Todo
    {
        public int id { get; set; }
        public String title { get; set; }
        public String Description { get; set; }

        public DateTime created { get; set; }

        public DateTime Due { get; set; }

        public TodoStatus status { get; set; }
    }
}
