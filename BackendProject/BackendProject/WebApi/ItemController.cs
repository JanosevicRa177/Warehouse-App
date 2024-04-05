using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Item;

[ApiController]
[Route("/items")]
public class ItemController: ControllerBase
{

    private readonly ISender _sender;
    
    public ItemController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/items")]
	public async Task<IActionResult> Create([FromBody] CreateItemDto createItemDto)
	{
			
	    await _sender.Send(new CreateItemCommand(createItemDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/items")]
	public async Task<IActionResult> Update([FromBody] UpdateItemDto updateItemDto)
	{
	    await _sender.Send(new UpdateItemCommand(updateItemDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/items")]
	public async Task<IActionResult> Delete([FromBody] DeleteItemDto deleteItemDto)
	{		
	    await _sender.Send(new DeleteItemCommand(deleteItemDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/items")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllItemQuery());
	    return Ok();
	}
	    