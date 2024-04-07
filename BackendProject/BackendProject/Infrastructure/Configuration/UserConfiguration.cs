using BackendProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendProject.Infrastructure.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
		builder
		    .Property(x => x.Id)
		    .ValueGeneratedOnAdd();
        builder.HasOne(x => x.Address)
        .WithOne(); 
         

        
    }
}