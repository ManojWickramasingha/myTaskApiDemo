﻿using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Services.ViewModels
{
   public  class ExpenseDTO
    {
       
        public int id { get; set; }
        public String title { get; set; }
      
        public DateTime created { get; set; }

        public DateTime Due { get; set; }

        public String status { get; set; }

        public double Amount { get; set; }

    }
}
