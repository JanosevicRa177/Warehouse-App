using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/item")]
public class ItemController: ControllerBase
{

    private readonly ISender _sender;
    
    public ItemController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/item")]
	public async Task<IActionResult> Create([FromBody] CreateItemDto createItemDto)
	{
			
	    await _sender.Send(new CreateItemCommand(createItemDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/item")]
	public async Task<IActionResult> Update([FromBody] UpdateItemDto updateItemDto)
	{
	    await _sender.Send(new UpdateItemCommand(updateItemDto.ToEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/item/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteItemCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/item")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllItemsQuery());
	    return Ok();
	}
}