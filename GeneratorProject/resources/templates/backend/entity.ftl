<#if class.hasEnum>   
using BackendProject.Model.Enum;
</#if>   

namespace BackendProject.${class.typePackage};

public class ${class.name} : Entity
{  
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
	public ${class.name}(){ }
	<#assign y = 0>
	<#list properties as property><#if property.upper == 1 ><#assign y++></#if></#list>
<#if y != 0>
	public ${class.name}(<#assign x = 0><#list properties as property><#if property.upper == 1 ><#if x != 0>, </#if><#assign x++><#if property.isClass >Guid ${property.name?uncap_first}Id <#else>${property.type.name} ${property.name?uncap_first}</#if></#if></#list>) 
	{
	<#list properties as property>  
	<#if property.upper == 1 >
		<#if property.isClass >   
      	${property.name}Id = ${property.name?uncap_first}Id;
      	<#else>
      	${property.name} = ${property.name?uncap_first};
	    </#if>
    </#if>  
	</#list>
	}
</#if>
}
