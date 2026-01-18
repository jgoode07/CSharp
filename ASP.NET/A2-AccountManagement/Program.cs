using A2_AccountManagement.Data;
using A2_AccountManagement.Models;
using A2_AccountManagement.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register database context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Register AccountService for dependency injection
builder.Services.AddScoped<AccountService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Register a new account
app.MapPost("/accounts", (Account account, AccountService service) =>
{
    var created = service.Create(account);
    return Results.Created($"/accounts/{created.Id}", created);
});

// Get account by ID
app.MapGet("/accounts/{id:int}", (int id, AccountService service) =>
{
    var account = service.GetById(id);
    return account == null ? Results.NotFound() : Results.Ok(account);
});

// Get account by email (query string)
app.MapGet("/accounts/by-email", (string email, AccountService service) =>
{
    var account = service.GetByEmail(email);
    return account == null ? Results.NotFound() : Results.Ok(account);
});

// Update account by ID
app.MapPut("/accounts/{id:int}", (int id, Account account, AccountService service) =>
{
    account.Id = id;
    var updated = service.Update(account);
    return updated ? Results.NoContent() : Results.NotFound();
});

app.Run();
