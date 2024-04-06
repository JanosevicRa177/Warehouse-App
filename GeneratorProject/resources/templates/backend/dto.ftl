using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;

<#if type == "create">
public class Create${classname}Dto {
	<#list properties as property>
	<#if property.upper == 1 >
	<#if property.isClass && property.lower == 1>
      public int ${property.name}Id {get; set;}
      public ${property.type.name} ${property.name} {get; set;}  
    <#elseif !property.isClass>
      public ${property.type.name} ${property.name} {get; set;}   
    </#if> 
    <#elseif property.upper == -1 > 
      public List<${property.type.name}> ${property.name} {get; set;} = new();
    </#if>     
	</#list>
		
	public ${classname} ToEntity() {
		var ${classname[0]?lower_case + classname[1..]} = new ${classname}(<#assign x = 0><#list properties as property><#if property.upper == 1 ><#if property.isClass && property.lower == 1 ><#if x != 0>, </#if><#assign x++>${property.name}Id <#elseif !property.isClass><#if x != 0>, </#if><#assign x++>${property.name}</#if></#if></#list>);
		return ${classname[0]?lower_case + classname[1..]};
	}
}
</#if>

<#if type == "update">
public class Update${classname}Dto {
	<#list properties as property>
	<#if property.upper == 1 >
	<#if property.isClass && property.lower == 1>
      public int ${property.name}Id {get; set;}
      public ${property.type.name} ${property.name} {get; set;}  
    <#elseif !property.isClass>
      public ${property.type.name} ${property.name} {get; set;}   
    </#if> 
    <#elseif property.upper == -1 > 
	<#if property.isClass>
      public List<int> ${property.name}Ids {get; set;} = new();
    <#else>
      public List<${property.type.name}> ${property.name} {get; set;} = new();
    </#if> 
    </#if>     
	</#list>
	
	public ${classname} ToEntity() {
		var ${classname[0]?lower_case + classname[1..]} = new ${classname}(<#assign x = 0><#list properties as property><#if property.upper == 1 ><#if property.isClass && property.lower == 1 ><#if x != 0>, </#if><#assign x++>${property.name}Id <#elseif !property.isClass><#if x != 0>, </#if><#assign x++>${property.name}</#if></#if></#list>);
		<#list properties as property>
		<#if property.upper == -1 && property.isClass>
		${classname[0]?lower_case + classname[1..]}.${property.name} = ${property.name}Ids.Select(id => new ${property.type.name}
		{
			Id = id
		}).ToList();
   		</#if>
		</#list>
		
		return ${classname[0]?lower_case + classname[1..]};
	}
}
</#if>