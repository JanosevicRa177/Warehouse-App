using System.Reflection;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Persistence;

public class MainDbContext: DbContext
{
    
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
    }
    
    public DbSet<Warehouse> Warehouses { get; set; } = null!;  
    public DbSet<Product> Products { get; set; } = null!;  
    public DbSet<Item> Items { get; set; } = null!;  
    public DbSet<Receipt> Receipts { get; set; } = null!;  
    public DbSet<User> Users { get; set; } = null!;  
    public DbSet<ReceiptItem> ReceiptItems { get; set; } = null!;  
    public DbSet<Address> Addresses { get; set; } = null!;  
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}