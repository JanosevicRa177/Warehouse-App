using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



<#if type == "create">
public sealed record ${name}(${classname} ${classname}) : ICommand<int>;
</#if>

<#if type == "update">
public sealed record ${name}(${classname} ${classname}) : ICommand;
</#if>

<#if type == "delete">
public sealed record ${name}(int Id) : ICommand;
</#if>