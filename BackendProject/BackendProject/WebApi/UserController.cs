using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.User;

[ApiController]
[Route("/users")]
public class UserController: ControllerBase
{

    private readonly ISender _sender;
    
    public UserController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/users")]
	public async Task<IActionResult> Create([FromBody] CreateUserDto createUserDto)
	{
			
	    await _sender.Send(new CreateUserCommand(createUserDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/users")]
	public async Task<IActionResult> Update([FromBody] UpdateUserDto updateUserDto)
	{
	    await _sender.Send(new UpdateUserCommand(updateUserDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/users")]
	public async Task<IActionResult> Delete([FromBody] DeleteUserDto deleteUserDto)
	{		
	    await _sender.Send(new DeleteUserCommand(deleteUserDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/users")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllUserQuery());
	    return Ok();
	}
	    