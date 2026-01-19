using A2_AccountManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace A2_AccountManagement.Data;

public class AppDbContext : DbContext
{
    // Constructor that receives options from Program.cs
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; } = null!;
}
