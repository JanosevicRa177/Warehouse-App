using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Receipt;

[ApiController]
[Route("/receipts")]
public class ReceiptController: ControllerBase
{

    private readonly ISender _sender;
    
    public ReceiptController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/receipts")]
	public async Task<IActionResult> Create([FromBody] CreateReceiptDto createReceiptDto)
	{
			
	    await _sender.Send(new CreateReceiptCommand(createReceiptDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/receipts")]
	public async Task<IActionResult> Update([FromBody] UpdateReceiptDto updateReceiptDto)
	{
	    await _sender.Send(new UpdateReceiptCommand(updateReceiptDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/receipts")]
	public async Task<IActionResult> Delete([FromBody] DeleteReceiptDto deleteReceiptDto)
	{		
	    await _sender.Send(new DeleteReceiptCommand(deleteReceiptDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/receipts")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllReceiptQuery());
	    return Ok();
	}
	    