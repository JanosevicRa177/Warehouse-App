using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/user")]
public class UserController: ControllerBase
{

    private readonly ISender _sender;
    
    public UserController(ISender sender) {
    	_sender = sender;
    }
    
	[HttpPost]    
	[Route("/user")]
	public async Task<IActionResult> Create([FromBody] CreateUserDto createUserDto)
	{
			
	    await _sender.Send(new CreateUserCommand(createUserDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/user/{id}")]
	public async Task<IActionResult> Update([FromBody] UpdateUserDto updateUserDto, int id)
	{
	    await _sender.Send(new UpdateUserCommand(updateUserDto, id));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/user/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteUserCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/user")]
	public async Task<IActionResult> ReadAll()
	{
	    var users =  await _sender.Send(new ReadAllUsersQuery());
	    return Ok(users);
	}
	[HttpGet]    
	[Route("/user/{id}")]
	public async Task<IActionResult> ReadOne(int id)
	{
	    var user = await _sender.Send(new ReadOneUserQuery(id));
	    return Ok(user);
	}  
}