using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/address")]
public class AddressController: ControllerBase
{

    private readonly ISender _sender;
    
    public AddressController(ISender sender) {
    	_sender = sender;
    }
    
	[HttpPost]    
	[Route("/address")]
	public async Task<IActionResult> Create([FromBody] CreateAddressDto createAddressDto)
	{
			
	    await _sender.Send(new CreateAddressCommand(createAddressDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/address/{id}")]
	public async Task<IActionResult> Update([FromBody] UpdateAddressDto updateAddressDto,int id)
	{
		var address = updateAddressDto.ToEntity();
	    await _sender.Send(new UpdateAddressCommand(address));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/address/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteAddressCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/address")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllAddressesQuery());
	    return Ok();
	}
	[HttpGet]    
	[Route("/address/{id}")]
	public async Task<IActionResult> ReadOne(int id)
	{
	    await _sender.Send(new ReadOneAddressQuery(id));
	    return Ok();
	}  
}