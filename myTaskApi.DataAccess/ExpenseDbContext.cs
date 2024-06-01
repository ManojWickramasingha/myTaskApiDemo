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

        public DbSet<Income> Incomes { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Saving> Savings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-DV7M2UV; Database = ExpenseDB; user=sa; password=manoj@123";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Saving>().HasData(new Saving[] { 
            
                new Saving
                {
                    Id = 10,
                    Name = "manoj",
                    Description = "Saving montlty utility Income",
                    UserId = 100
                },

                new Saving
                {
                    Id = 12,
                    Name = "Lahiru",
                    Description="Saving Salary",
                    UserId = 101
                }

            });
            modelBuilder.Entity<User>().HasData(new User[] { 
                
                new User
                {
                    Id=100,
                    Name="manoj",
                    Gmail="wicmanoj@gmail.com",
                    Password="manoj@123"
                },
                new User
                {
                    Id=101,
                    Name="Menaka",
                    Gmail="Menaka@gmail.com",
                    Password="menaka@123"
                },
                new User
                {
                    Id=102,
                    Name="Ashen",
                    Gmail="Ashen@gmail.com",
                    Password="Ashen@123"
                },
                new User
                {
                    Id=103,
                    Name="Chinthaka",
                    Gmail="Chinthaka@gmail.com",
                    Password="Chinthaka@123"
                }
            });
            modelBuilder.Entity<Income>().HasData(new Income[] {

                new Income
                {
                    Id = "c001",
                    Amount = 450.0,
                    Categories = "Utility Income",
                    description = "receive bording fees",
                    start = DateTime.Now,
                    UserId = 100
                },
                new Income
                {
                     Id = "c002",
                    Amount = 450.0,
                    Categories = "Salary",
                    description = "receive monthly salary",
                    start = DateTime.Now,
                    UserId = 102
                }
            }); 
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
                Adminid = 1,
                UserId = 100

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
                Adminid = 2,
                UserId = 101
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
                Adminid = 1,
                UserId = 102
              

           }

            });
        }


    }
}
