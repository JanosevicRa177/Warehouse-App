using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public class DeleteItemCommandHandler : ICommandHandler<DeleteItemCommand> {
		private IItemRepository _repository;
	
	public DeleteItemCommandHandler (IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteItemCommand request, CancellationToken cancellationToken) {
		var item = _repository.Find(request.Id);
		if(item is null) return;
		_repository.Delete(item);
	}
}
