using BackendProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendProject.Infrastructure.Configuration;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
		builder
		    .Property(x => x.Id)
		    .ValueGeneratedOnAdd();
        builder.HasMany(x => x.Products)
        .WithOne(x => x.Item) 
        .HasForeignKey(x => x.ItemId); 

        builder.HasMany(x => x.ReceiptItems)
        .WithOne(x => x.Item) 
        .HasForeignKey(x => x.ItemId); 

        
    }
}