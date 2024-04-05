using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Warehouse;

[ApiController]
[Route("/warehouses")]
public class WarehouseController: ControllerBase
{

    private readonly ISender _sender;
    
    public WarehouseController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/warehouses")]
	public async Task<IActionResult> Create([FromBody] CreateWarehouseDto createWarehouseDto)
	{
			
	    await _sender.Send(new CreateWarehouseCommand(createWarehouseDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/warehouses")]
	public async Task<IActionResult> Update([FromBody] UpdateWarehouseDto updateWarehouseDto)
	{
	    await _sender.Send(new UpdateWarehouseCommand(updateWarehouseDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/warehouses")]
	public async Task<IActionResult> Delete([FromBody] DeleteWarehouseDto deleteWarehouseDto)
	{		
	    await _sender.Send(new DeleteWarehouseCommand(deleteWarehouseDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/warehouses")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllWarehouseQuery());
	    return Ok();
	}
	    