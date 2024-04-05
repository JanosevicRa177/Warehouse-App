using BackendProject.Application.Shared;
using BackendProject.Model.${classname};


<#if type == "create">
public sealed record ${name}(${classname} obj) : ICommand<Guid>;
</#if>

<#if type == "update">
public sealed record ${name}(${classname} obj) : ICommand<Guid>;
</#if>

<#if type == "delete">
public sealed record ${name}(Guid id) : ICommand;
</#if>