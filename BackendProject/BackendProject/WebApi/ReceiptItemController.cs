using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/receipt-item")]
public class ReceiptItemController: ControllerBase
{

    private readonly ISender _sender;
    
    public ReceiptItemController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/receipt-item")]
	public async Task<IActionResult> Create([FromBody] CreateReceiptItemDto createReceiptItemDto)
	{
			
	    await _sender.Send(new CreateReceiptItemCommand(createReceiptItemDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/receipt-item")]
	public async Task<IActionResult> Update([FromBody] UpdateReceiptItemDto updateReceiptItemDto)
	{
	    await _sender.Send(new UpdateReceiptItemCommand(updateReceiptItemDto.ToEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/receipt-item/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteReceiptItemCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/receipt-item")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllReceiptItemsQuery());
	    return Ok();
	}
}