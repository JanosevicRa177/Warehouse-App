using BackendProject.Infrastructure.Interfaces;
using BackendProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using BackendProject.Model;

namespace BackendProject.Infrastructure.${class.typePackage};

public class ${class.name}Repository : BaseRepository<${class.name}>, I${class.name}Repository 
{  
    private readonly MainDbContext _context;
    public ${class.name}Repository(MainDbContext context) : base(context)
    {
        _context = context;
    }
    
    public override ${class.name}? Find(int id)
    {
        return _context.<#if class.name?ends_with("s")>${class.name}es<#elseif class.name?ends_with("y")>${class.name?substring(0, class.name?length - 1)}ies<#else>${class.name}s</#if>
<#list properties as property>
<#if property.isClass && property.lower != 0> 
	    .Include(x => x.${property.name})
</#if> 
<#if property.isClass && property.upper == -1> 
	    .Include(x => x.${property.name})
</#if>    
</#list>
        .FirstOrDefault(x => x.Id == id);
    }
    public override IEnumerable<${class.name}> FindAll()
    {
        return _context.<#if class.name?ends_with("s")>${class.name}es<#elseif class.name?ends_with("y")>${class.name?substring(0, class.name?length - 1)}ies<#else>${class.name}s</#if>
<#list properties as property>
<#if property.isClass && property.lower != 0> 
	    .Include(x => x.${property.name})
</#if> 
<#if property.isClass && property.upper == -1> 
	    .Include(x => x.${property.name})
</#if>   
</#list> 
        .ToList();
    }
}
