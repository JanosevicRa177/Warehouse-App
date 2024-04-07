using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

<#if type == "readAll">
public sealed record ${name}() : IQuery<IEnumerable<${classname}>>;
</#if>
<#if type == "read">
public sealed record ${name}(int Id) : IQuery<${classname}>;
</#if>
 
