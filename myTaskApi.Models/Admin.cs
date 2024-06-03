using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class Admin
    {
        [Required]
        public int id { get; set; }
        [MaxLength(100)]
        public String name { get; set; }

        public String Gmail { get; set; }
     
       
    }
}
