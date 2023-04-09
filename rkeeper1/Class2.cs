using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rkeeper;

namespace rkeeper1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Dish> Dishs => Set<Dish>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Status> Statuses => Set<Status>();
        public DbSet<DishType> DishTypes => Set<DishType>();

        public ApplicationDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\Visual Studio Projects\rkeeper1\rkeeper1\data.db");
        }
    }
}
