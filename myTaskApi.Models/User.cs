using myTaskApi.Model;
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

        [MaxLength(100)]
        public int AddressNo { get; set; }

        [MaxLength(50)]
        public String Street { get; set; }

        [MaxLength(50)]
        [Required]
        public String City { get; set; }

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

        public ICollection<Income> Incomes { get; set; } = new List<Income>();
    }
}
