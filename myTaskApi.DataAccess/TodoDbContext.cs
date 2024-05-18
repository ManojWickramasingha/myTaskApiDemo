using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myTaskApi.Model;

namespace myTaskApi.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-DV7M2UV; Database = myTodoDB; user=sa; password=manoj@123";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                id = 10,
                title = "get book for school from DB",
                Description = "Get some text books for school",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = TodoStatus.New,
            });
        }
    }
}
