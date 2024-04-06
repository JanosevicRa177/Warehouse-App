using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/")]
public class UserController: ControllerBase
{

    private readonly ISender _sender;
    
    public UserController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/")]
	public async Task<IActionResult> Create([FromBody] CreateUserDto createUserDto)
	{
			
	    await _sender.Send(new CreateUserCommand(createUserDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/")]
	public async Task<IActionResult> Update([FromBody] UpdateUserDto updateUserDto)
	{
	    await _sender.Send(new UpdateUserCommand(updateUserDto.ToEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("//{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteUserCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllUsersQuery());
	    return Ok();
	}
}