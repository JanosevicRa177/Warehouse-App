using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Worker;

[ApiController]
[Route("/workers")]
public class WorkerController: ControllerBase
{

    private readonly ISender _sender;
    
    public WorkerController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/workers")]
	public async Task<IActionResult> Create([FromBody] CreateWorkerDto createWorkerDto)
	{
			
	    await _sender.Send(new CreateWorkerCommand(createWorkerDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/workers")]
	public async Task<IActionResult> Update([FromBody] UpdateWorkerDto updateWorkerDto)
	{
	    await _sender.Send(new UpdateWorkerCommand(updateWorkerDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/workers")]
	public async Task<IActionResult> Delete([FromBody] DeleteWorkerDto deleteWorkerDto)
	{		
	    await _sender.Send(new DeleteWorkerCommand(deleteWorkerDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/workers")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllWorkerQuery());
	    return Ok();
	}
	    