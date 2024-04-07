using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, int> {

	private readonly IProductRepository _repository;
	
	public CreateProductCommandHandler (IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken) {
	   var product = await _repository.Create(request.Product);
	   return product.Id;
	}
}
