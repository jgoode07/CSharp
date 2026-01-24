using A3_ProductsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace A3_ProductsApi.Data;

public class AppDbContext : DbContext
{
    // EF Core options are passed in from Program.cs (dependency injection)
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Price stored as decimal(18,2)
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);
    }
}