using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myTaskApi.Model;
using myTaskApi.Models;

namespace myTaskApi.DataAccess
{
    public class ExpenseDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-DV7M2UV; Database = ExpenseDB; user=sa; password=manoj@123";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin[] { 
            
                new Admin { id = 1, name = "manoj"},
                new Admin { id = 2, name = "Lahiru"},
                new Admin { id = 3, name = "kasun"},
                new Admin { id = 4, name = "malindu"},
                new Admin {id = 5, name= "Amila" }

            });
            modelBuilder.Entity<Expense>().HasData(new Expense[] {
           new Expense {
                id = 1,
                title = "Expense Tax record in database",
                Description = "Get some text books for school",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = ExpenseStatus.New,
                Amount = 3000.00,
                Adminid = 1

            },

           new Expense
           {
                id = 2,
                title = "Expense For Water bill",
                Description = "Goverment Tax Added water bill",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = ExpenseStatus.New,
                Amount = 3890.00,
                Adminid = 2
           },

           new Expense
           {
                id = 3,
                title = "Expense For Current bill",
                Description = "Goverment Tax Added current bill",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = ExpenseStatus.New,
                Amount = 3780.00,
                Adminid = 1

           }

            });
        }


    }
}
