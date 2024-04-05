using BackendProject.Model;



<#if type == "create">
class Create${classname}Dto {
	<#list properties as property>
	<#if property.upper == 1 >
	<#if property.isClass && property.lower == 1>  
  	public ${property.type.name} ${property.name} {get; public set;}  
    <#elseif !property.isClass> 
  	public ${property.type.name} ${property.name} {get; public set;}   
    </#if> 
	</#if>     
	</#list>
		
	public ${classname} toEntity() {
		${classname} obj = new ${classname}();
		<#list properties as property>
		<#if property.upper == 1 >
		<#if property.isClass && property.lower == 1>  
      	obj.${property.name} = ${property.name}; 
    	<#elseif !property.isClass> 
      	obj.${property.name} = ${property.name};  
    	</#if> 
    	</#if>     
		</#list>
	}
}
</#if>

<#if type == "update">
class Update${classname}Dto {
	<#list properties as property>
	<#if property.upper == 1 >
	<#if property.isClass && property.lower == 1>  
    public ${property.type.name} ${property.name} {get; public set;}  
    <#elseif !property.isClass> 
	public ${property.type.name} ${property.name} {get; public set;}   
	</#if> 
	</#if>     
	</#list>
	
	public ${classname} toEntity() {
		${classname} obj = new ${classname}();
		<#list properties as property>
		<#if property.upper == 1 >
		<#if property.isClass && property.lower == 1>  
      	obj.${property.name} = ${property.name}; 
    	<#elseif !property.isClass> 
      	obj.${property.name} = ${property.name};  
    	</#if> 
		</#if>     
		</#list>
	}
}
</#if>