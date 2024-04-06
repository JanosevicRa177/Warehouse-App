using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

<#if type == "readAll">
public sealed record ${name}() : IQuery<List<${classname}>>;
</#if>


<#if type == "read">
public sealed record ${name}(int id) : IQuery<${classname}>;
</#if>
 
