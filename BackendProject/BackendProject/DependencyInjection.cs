using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Repositories;

namespace BackendProject;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IWarehouseRepository, WarehouseRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IItemRepository, ItemRepository>();
        services.AddScoped<IReceiptRepository, ReceiptRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IReceiptItemRepository, ReceiptItemRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        
        return services;
    }
}