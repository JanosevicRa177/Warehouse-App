using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/warehouse")]
public class WarehouseController: ControllerBase
{

    private readonly ISender _sender;
    
    public WarehouseController(ISender sender) {
    	_sender = sender;
    }
    
	[HttpPost]    
	[Route("/warehouse")]
	public async Task<IActionResult> Create([FromBody] CreateWarehouseDto createWarehouseDto)
	{
			
	    await _sender.Send(new CreateWarehouseCommand(createWarehouseDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/warehouse/{id}")]
	public async Task<IActionResult> Update([FromBody] UpdateWarehouseDto updateWarehouseDto,int id)
	{
		var warehouse = updateWarehouseDto.ToEntity();
		warehouse.Id = id;
	    await _sender.Send(new UpdateWarehouseCommand(warehouse));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/warehouse/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteWarehouseCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/warehouse")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllWarehousesQuery());
	    return Ok();
	}
	[HttpGet]    
	[Route("/warehouse/{id}")]
	public async Task<IActionResult> ReadOne(int id)
	{
	    await _sender.Send(new ReadOneWarehouseQuery(id));
	    return Ok();
	}  
}