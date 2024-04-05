using BackendProject.Application.Shared;
using BackendProject.Model.${classname};


<#if type == "readAll">
public sealed record ${name}() : IQuery<List<${classname}>>;
</#if>


<#if type == "read">
public sealed record ${name}(Guid id) : IQuery<${classname}>;
</#if>
 
