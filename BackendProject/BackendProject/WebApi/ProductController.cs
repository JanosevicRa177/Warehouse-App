using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using BackendProject.WebApi.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.WebApi;

[ApiController]
[Route("/product")]
public class ProductController: ControllerBase
{

    private readonly ISender _sender;
    
    public ProductController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/product")]
	public async Task<IActionResult> Create([FromBody] CreateProductDto createProductDto)
	{
			
	    await _sender.Send(new CreateProductCommand(createProductDto.ToEntity()));
	    return Ok();
	}
	
	[HttpPatch]    
	[Route("/product")]
	public async Task<IActionResult> Update([FromBody] UpdateProductDto updateProductDto)
	{
	    await _sender.Send(new UpdateProductCommand(updateProductDto.ToEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/product/{id}")]
	public async Task<IActionResult> Delete(int id)
	{		
	    await _sender.Send(new DeleteProductCommand(id));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/product")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllProductsQuery());
	    return Ok();
	}
}