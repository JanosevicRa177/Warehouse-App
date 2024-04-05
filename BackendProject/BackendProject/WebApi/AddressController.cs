using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Address;

[ApiController]
[Route("/addresss")]
public class AddressController: ControllerBase
{

    private readonly ISender _sender;
    
    public AddressController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/addresss")]
	public async Task<IActionResult> Create([FromBody] CreateAddressDto createAddressDto)
	{
			
	    await _sender.Send(new CreateAddressCommand(createAddressDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/addresss")]
	public async Task<IActionResult> Update([FromBody] UpdateAddressDto updateAddressDto)
	{
	    await _sender.Send(new UpdateAddressCommand(updateAddressDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/addresss/{id}")]
	public async Task<IActionResult> Delete(Guid id)
	{		
	    await _sender.Send(new DeleteAddressCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/addresss")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllAddressQuery());
	    return Ok();
	}
	    