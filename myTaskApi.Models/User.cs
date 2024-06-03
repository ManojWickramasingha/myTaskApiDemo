using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Gmail { get; set; }
        [MaxLength(50)]
        public String Password { get; set; }
    }
}
