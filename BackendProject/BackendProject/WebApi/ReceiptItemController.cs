using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.ReceiptItem;

[ApiController]
[Route("/receiptitems")]
public class ReceiptItemController: ControllerBase
{

    private readonly ISender _sender;
    
    public ReceiptItemController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/receiptitems")]
	public async Task<IActionResult> Create([FromBody] CreateReceiptItemDto createReceiptItemDto)
	{
			
	    await _sender.Send(new CreateReceiptItemCommand(createReceiptItemDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/receiptitems")]
	public async Task<IActionResult> Update([FromBody] UpdateReceiptItemDto updateReceiptItemDto)
	{
	    await _sender.Send(new UpdateReceiptItemCommand(updateReceiptItemDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/receiptitems/{id}")]
	public async Task<IActionResult> Delete(Guid id)
	{		
	    await _sender.Send(new DeleteReceiptItemCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/receiptitems")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllReceiptItemQuery());
	    return Ok();
	}
	    