using BackendProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendProject.Infrastructure.Configuration;

public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
{
    public void Configure(EntityTypeBuilder<Warehouse> builder)
    {
        builder.HasMany(x => x.ReceiptItems)
        .WithOne(x => x.Warehouse) 
        .HasForeignKey(x => x.WarehouseId); 

        builder.HasOne(x => x.Address)
        .WithOne(); 
         

        builder.HasMany(x => x.Products)
        .WithOne(x => x.Warehouse) 
        .HasForeignKey(x => x.WarehouseId); 

        builder.HasMany(x => x.Workers)
        .WithOne(x => x.Warehouse) 
        .HasForeignKey(x => x.WarehouseId); 

        
    }
}