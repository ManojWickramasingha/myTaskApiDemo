using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTaskApi.Models
{
    public class Saving
    {
        [Required]
        public int Id { get; set; }
        public String Name { get; set; }
        [MaxLength(50)]
        public String Description { get; set; }

        [Required]
       public float Save { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
