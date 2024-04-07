using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/receipt")]
public class ReceiptController: ControllerBase
{

    private readonly ISender _sender;
    
    public ReceiptController(ISender sender) {
    	_sender = sender;
    }
    
	[HttpPost]    
	[Route("/receipt")]
	public async Task<IActionResult> Create([FromBody] CreateReceiptDto createReceiptDto)
	{
			
	    await _sender.Send(new CreateReceiptCommand(createReceiptDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/receipt/{id}")]
	public async Task<IActionResult> Update([FromBody] UpdateReceiptDto updateReceiptDto,int id)
	{
		var receipt = updateReceiptDto.ToEntity();
		receipt.Id = id;
	    await _sender.Send(new UpdateReceiptCommand(receipt));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/receipt/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteReceiptCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/receipt")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllReceiptsQuery());
	    return Ok();
	}
	[HttpGet]    
	[Route("/receipt/{id}")]
	public async Task<IActionResult> ReadOne(int id)
	{
	    await _sender.Send(new ReadOneReceiptQuery(id));
	    return Ok();
	}  
}