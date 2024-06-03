using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class EBudget
    {
        [Required]
        public String id { get; set; }
        [Required]
        public double Amount { get; set; }
        [MaxLength(120)]
        public String Description { get; set; }
    }
}
