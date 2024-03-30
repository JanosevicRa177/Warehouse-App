<#if class.hasEnum>   
using BackendProject.Model.Enum;
</#if>   

namespace BackendProject.${class.typePackage};

${class.visibility} class ${class.name} 
{  
      public Guid Id {get; private set;}
<#list properties as property>
	<#if property.upper == 1 >
	<#if property.isClass >   
      public Guid ${property.name}Id {get; private set;} 
    </#if>  
      public ${property.type.name} ${property.name} {get; ${property.visibility} set;}
    <#elseif property.upper == -1 > 
      public List<${property.type.name}> ${property.name} {get; ${property.visibility} set;} = new();
    </#if>     
</#list>
}
