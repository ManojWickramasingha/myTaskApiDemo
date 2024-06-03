using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class Income
    {
        [Required]
        
        public String Id { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public String Categories { get; set; }
        [MaxLength(50)]
        public String description { get; set; }
        public DateTime start { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
