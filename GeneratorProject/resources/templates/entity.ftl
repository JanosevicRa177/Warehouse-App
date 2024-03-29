<#if class.hasEnum>   
using BackendProject.Model.Enum;
</#if>   

namespace BackendProject.${class.typePackage};

${class.visibility} class ${class.name} 
{  
<#list properties as property>
	<#if property.upper == 1 >   
      ${property.visibility} ${property.type.name} ${property.name} {get; set;}
    <#elseif property.upper == -1 > 
      ${property.visibility} List<${property.type.name}> ${property.name} {get; set;} = new();
    </#if>     
</#list>
}
