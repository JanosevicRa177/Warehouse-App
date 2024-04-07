using BackendProject.Application.Interfaces;
<#if type == "update">
using BackendProject.WebApi.Dtos;
<#elseif type == "create">
using BackendProject.Model;
</#if>

namespace BackendProject.Application.Commands;

<#if type == "create">
public sealed record ${name}(${classname} ${classname}) : ICommand<int>;
</#if>
<#if type == "update">
public sealed record ${name}(Update${classname}Dto Update${classname}Dto, int Id) : ICommand;
</#if>
<#if type == "delete">
public sealed record ${name}(int Id) : ICommand;
</#if>