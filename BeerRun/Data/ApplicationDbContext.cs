using BeerRun.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeerRun.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductLocation> ProductLocation { get; set; }
        public DbSet<ProductType> ProductType { get; set; }

    }
}
