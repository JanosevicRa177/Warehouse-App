using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateItemCommandHandler : ICommandHandler<CreateItemCommand, int> {

	private readonly IItemRepository _repository;
	
	public CreateItemCommandHandler (IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken) {
	   var item = await _repository.Create(request.Item);
	   return item.Id;
	}
}
