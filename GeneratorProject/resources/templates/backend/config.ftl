using BackendProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackendProject.Infrastructure.Configuration;

public class ${class.name}Configuration : IEntityTypeConfiguration<${class.name}>
{
    public void Configure(EntityTypeBuilder<${class.name}> builder)
    {
		builder
		    .Property(x => x.Id)
		    .ValueGeneratedOnAdd();
<#list associations as association>
<#if association.notOwner.isOwnerOf>
        builder.<#if association.notOwner.upper == -1 >HasMany(x => x.${association.notOwner.name})<#else>HasOne(x => x.${association.notOwner.name})</#if>
        .<#if association.owner.upper == -1 >WithMany(x => x.${association.owner.name})<#else>WithOne(<#if association.owner.lower == 1>x => x.${association.owner.name}</#if>)</#if><#if (association.notOwner.upper == -1 && association.owner.upper == -1) || (association.notOwner.upper == 1 && association.owner.upper == 1) >;</#if> 
        <#if association.notOwner.upper == -1 && association.owner.upper == 1 >.HasForeignKey(x => x.${association.owner.name}Id);<#elseif association.notOwner.upper == 1 && association.owner.upper == -1>.HasForeignKey(x => x.${association.notOwner.name}Id);</#if> 

</#if>
</#list>
        
    }
}