using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Manager;

[ApiController]
[Route("/managers")]
public class ManagerController: ControllerBase
{

    private readonly ISender _sender;
    
    public ManagerController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/managers")]
	public async Task<IActionResult> Create([FromBody] CreateManagerDto createManagerDto)
	{
			
	    await _sender.Send(new CreateManagerCommand(createManagerDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/managers")]
	public async Task<IActionResult> Update([FromBody] UpdateManagerDto updateManagerDto)
	{
	    await _sender.Send(new UpdateManagerCommand(updateManagerDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/managers")]
	public async Task<IActionResult> Delete([FromBody] DeleteManagerDto deleteManagerDto)
	{		
	    await _sender.Send(new DeleteManagerCommand(deleteManagerDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/managers")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllManagerQuery());
	    return Ok();
	}
	    