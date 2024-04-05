using BackendProject.Model;
using BackendProject.Application.Commands;
using BackendProject.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Product;

[ApiController]
[Route("/products")]
public class ProductController: ControllerBase
{

    private readonly ISender _sender;
    
    public ProductController(ISender sender) {
    	_sender = sender;
    }



	[HttpPost]    
	[Route("/products")]
	public async Task<IActionResult> Create([FromBody] CreateProductDto createProductDto)
	{
			
	    await _sender.Send(new CreateProductCommand(createProductDto.toEntity()));
	    return Ok();
	}
	}
	
	[HttpPatch]    
	[Route("/products")]
	public async Task<IActionResult> Update([FromBody] UpdateProductDto updateProductDto)
	{
	    await _sender.Send(new UpdateProductCommand(updateProductDto.toEntity()));
	    return Ok();
	}
	
	[HttpDelete]    
	[Route("/products")]
	public async Task<IActionResult> Delete([FromBody] DeleteProductDto deleteProductDto)
	{		
	    await _sender.Send(new DeleteProductCommand(deleteProductDto.toEntity()));
	    return Ok();
	}
	
	[HttpGet]    
	[Route("/products")]
	public async Task<IActionResult> ReadAll()
	{
	    await _sender.Send(new ReadAllProductQuery());
	    return Ok();
	}
	    