using BackendProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendProject.Infrastructure.Configuration;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
		builder
		    .Property(x => x.Id)
		    .ValueGeneratedOnAdd();
        
    }
}