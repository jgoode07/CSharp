using Microsoft.EntityFrameworkCore;
using Assignment06_QueryingWithLINQ.Models;

namespace Assignment06_QueryingWithLINQ.Data;

// DbContext used to access the Northwind database
public class NorthwindContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
                "Server=localhost\\SQLEXPRESS01;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
