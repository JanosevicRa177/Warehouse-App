using System.Reflection;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.Persistence;

public class MainDbContext: DbContext
{
    
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
    }
    
<#list classes as class>
    public DbSet<${class.name}> <#if class.name?ends_with("s")>${class.name}es<#elseif class.name?ends_with("y")>${class.name?substring(0, class.name?length - 1)}ies<#else>${class.name}s</#if> { get; set; } = null!;  
</#list>
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}