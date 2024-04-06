using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Repositories;

namespace BackendProject;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));
        services.AddValidatorsFromAssembly(assembly);
<#list classes as class>
        services.AddScoped<I${class.name}Repository, ${class.name}Repository>();
</#list>
        
        return services;
    }
}