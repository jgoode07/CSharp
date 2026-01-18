using A2_AccountManagement.Data;
using A2_AccountManagement.Models;

namespace A2_AccountManagement.Services;

public class AccountService
{
    private readonly AppDbContext _context;

    // DbContext is injected by ASP.NET
    public AccountService(AppDbContext context)
    {
        _context = context;
    }

    // Register a new account
    public Account Create(Account account)
    {
        _context.Accounts.Add(account);
        _context.SaveChanges();
        return account;
    }

    // Get account by ID
    public Account? GetById(int id)
    {
        return _context.Accounts.Find(id);
    }

    // Get account by email
    public Account? GetByEmail(string email)
    {
        return _context.Accounts.FirstOrDefault(a => a.Email == email);
    }

    // Update account
    public bool Update(Account updatedAccount)
    {
        var existing = _context.Accounts.Find(updatedAccount.Id);
        if (existing == null) return false;

        existing.FirstName = updatedAccount.FirstName;
        existing.LastName = updatedAccount.LastName;
        existing.Email = updatedAccount.Email;

        _context.SaveChanges();
        return true;
    }
}
