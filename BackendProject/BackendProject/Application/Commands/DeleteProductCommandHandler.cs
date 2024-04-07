using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand> {
		private IProductRepository _repository;
	
	public DeleteProductCommandHandler (IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken) {
		var product = _repository.Find(request.Id);
		if(product is null) return;
		_repository.Delete(product);
	}
}
