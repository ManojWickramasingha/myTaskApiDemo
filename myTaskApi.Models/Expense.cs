﻿using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Model
{
    public class Expense
    {
        public int id { get; set; }
        public String title { get; set; }
        public String Description { get; set; }

        public DateTime created { get; set; }

        public DateTime Due { get; set; }

        public ExpenseStatus status { get; set; }

        public double Amount { get; set; }

        public int Adminid { get; set; }

        public Admin Admin { get; set; }

       public int UserId { get; set; }
       public User User { get; set; }
      
    }
}
