using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("${route}")]
public class ${name}: ControllerBase
{

    private readonly ISender _sender;
    
    public ${name}(ISender sender) {
    	_sender = sender;
    }
    
	<#if create == true>
	[HttpPost]    
	[Route("${route}")]
	public async Task<IActionResult> Create([FromBody] Create${classname}Dto create${classname}Dto)
	{
			
	    await _sender.Send(new Create${classname}Command(create${classname}Dto.ToEntity()));
	    return Ok();
	}
	</#if>    
	
	<#if update == true>
	[HttpPatch]    
	[Route("${route}/{id}")]
	public async Task<IActionResult> Update([FromBody] Update${classname}Dto update${classname}Dto, int id)
	{
	    await _sender.Send(new Update${classname}Command(update${classname}Dto, id));
	    return Ok();
	}
	</#if>    
	
	<#if delete == true>
	[HttpDelete]    
	[Route("${route}/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new Delete${classname}Command(id));
	    return Ok();
	}
	</#if>    
	
	<#if readAll == true>
	[HttpGet]    
	[Route("${route}")]
	public async Task<IActionResult> ReadAll()
	{
	    var <#if classname?ends_with("s")>${classname?uncap_first}es<#elseif classname?ends_with("y")>${classname?uncap_first?substring(0, classname?length - 1)}ies<#else>${classname?uncap_first}s</#if> =  await _sender.Send(new ReadAll<#if classname?ends_with("s")>${classname}es<#elseif classname?ends_with("y")>${classname?substring(0, classname?length - 1)}ies<#else>${classname}s</#if>Query());
	    return Ok(<#if classname?ends_with("s")>${classname?uncap_first}es<#elseif classname?ends_with("y")>${classname?uncap_first?substring(0, classname?length - 1)}ies<#else>${classname?uncap_first}s</#if>);
	}
	</#if>  
	[HttpGet]    
	[Route("${route}/{id}")]
	public async Task<IActionResult> ReadOne(int id)
	{
	    var ${classname?uncap_first} = await _sender.Send(new ReadOne${classname}Query(id));
	    return Ok(${classname?uncap_first});
	}  
}