using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Activity13_EFCoreNorthwind.Data
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
