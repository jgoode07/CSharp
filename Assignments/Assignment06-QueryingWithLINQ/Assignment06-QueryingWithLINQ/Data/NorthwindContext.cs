using Activity13_EFCoreNorthwind.Models;
using Assignment06_LinqNorthwind.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment06_LinqNorthwind.Data
{
    // DbContext used to access the Northwind database
    public class NorthwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
