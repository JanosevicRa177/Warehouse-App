<#if class.hasEnum>   
using BackendProject.Model.Enum;
</#if>
using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.${class.typePackage};

<#function camelCaseToSnakeCase camelCaseString>
  <#local result = ""/>
  <#local first = true/>
  <#list 0..<camelCaseString?length as i>
    <#assign character = camelCaseString[i]>
    <#if character == character?lower_case>
      <#local result = result + character/>
    <#else>
      <#if !first>
      	<#local result = result + "_" + character?lower_case/>
  	  <#else>
      	<#assign first = false>
      </#if>
      <#local result = character?lower_case/>
    </#if>
  </#list>
  <#return result>
</#function>

[Table("${class.entity.tableName}")]
public class ${class.name}
{  
	[Column("id")] 
	public int Id {get; set;}
<#list properties as property>
	<#if property.upper == 1 >
	<#if property.isClass && property.lower == 1>  
	[Column("${camelCaseToSnakeCase(property.type.name)}_id")] 
    public int ${property.name}Id {get; set;}
    public ${property.type.name} ${property.name} {get; set;}  
    <#elseif !property.isClass> 
    [Column("${property.property.columnName}")] 
    public ${property.type.name} ${property.name} {get; set;}   
    </#if> 
    <#elseif property.upper == -1 > 
    public List<${property.type.name}> ${property.name} {get; set;} = new();
    </#if>     
</#list>
	public ${class.name}(){ }
	<#assign y = 0>
	<#list properties as property><#if property.upper == 1 ><#assign y++></#if></#list>
<#if y != 0>
	public ${class.name}(<#assign x = 0><#list properties as property><#if property.upper == 1 ><#if property.isClass && property.lower == 1 ><#if x != 0>, </#if><#assign x++>int ${property.name?uncap_first}Id <#elseif !property.isClass><#if x != 0>, </#if><#assign x++>${property.type.name} ${property.name?uncap_first}</#if></#if></#list>) 
	{
	<#list properties as property>  
	<#if property.upper == 1 >
		<#if property.isClass && property.lower == 1>   
      	${property.name}Id = ${property.name?uncap_first}Id;
      	<#elseif !property.isClass>
      	${property.name} = ${property.name?uncap_first};
	    </#if>
    </#if>  
	</#list>
	}
</#if>


	public void Update(${class.name} entity) {
		<#list properties as property>  
		<#if property.upper == 1 >
		<#if property.isClass != true>   
		${property.name} = entity.${property.name};
	    </#if>
	    </#if>  
		</#list>
	}
}
