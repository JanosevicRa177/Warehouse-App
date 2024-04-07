using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand> {
	private IProductRepository _repository;
	
	public UpdateProductCommandHandler (IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken) {
		var product = _repository.Find(request.Id);
		if(product is null) return;
		product.Update(request.UpdateProductDto);
		_repository.Update(product);
	}
}
