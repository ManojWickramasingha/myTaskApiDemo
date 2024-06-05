using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace myTaskApi.Models
{
    public class Report
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String ReportName { get; set; }
        [Required]
        [MaxLength(10)]
        public int ReportNo { get; set; }
        public String Description { get; set; }
        [Required]
        public DateTime Isuse { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
