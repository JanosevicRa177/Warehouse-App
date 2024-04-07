using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Repositories;

namespace BackendProject;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
<#list classes as class>
        services.AddScoped<I${class.name}Repository, ${class.name}Repository>();
</#list>
        
        return services;
    }
}