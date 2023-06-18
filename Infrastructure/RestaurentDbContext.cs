using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RestaurentDbContext : DbContext
    {

        // protected readonly IConfiguration Configuration;

        public RestaurentDbContext()
        {
            
        }

        public RestaurentDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //public RestaurentDbContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sqlite database
        //    options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        //}


        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Cashier> Cashiers { get; set; }
        public virtual DbSet<Cook> Cooks { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DeliveryBoy> DeliveryBoys { get; set; }
        public virtual DbSet<HomeDelivery> HomeDeliveries { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderDetails> MenuBills { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<SaleDetail> SaleDetails { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Waiter> Waiters { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        // public DbSet<__EFMigrationsHistory> __EFMigrationsHistory { get; set; }

    }


    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RestaurentDbContext>
    {
        public RestaurentDbContext CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile(@Directory.GetCurrentDirectory() + "/../Resto.API/appsettings.json")
            //    .Build();
            var builder = new DbContextOptionsBuilder<RestaurentDbContext>();
            //var connectionString = configuration.GetConnectionString("WebApiDatabase");
            builder.UseSqlite("Data Source=Restaurant.db");
            return new RestaurentDbContext(builder.Options);
        }
    }
}
