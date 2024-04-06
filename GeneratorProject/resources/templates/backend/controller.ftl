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
	[Route("${route}")]
	public async Task<IActionResult> Update([FromBody] Update${classname}Dto update${classname}Dto)
	{
	    await _sender.Send(new Update${classname}Command(update${classname}Dto.ToEntity()));
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
	    await _sender.Send(new ReadAll${classname}sQuery());
	    return Ok();
	}
	</#if>    
}