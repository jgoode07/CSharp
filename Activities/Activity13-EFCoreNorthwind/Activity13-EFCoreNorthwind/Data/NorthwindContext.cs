using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Activity13_EFCoreNorthwind.Models;

namespace Activity13_EFCoreNorthwind.Data
{
    // The database connection for the Northwind database
    public class NorthwindContext : DbContext
    {
        // Represents the Categories table in the database
        public DbSet<Category> Categories { get; set; }
        
        // Represents the Customers table
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=localhost\\SQLEXPRESS01;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
