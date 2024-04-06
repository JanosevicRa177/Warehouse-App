using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public class UpdateItemCommandHandler : ICommandHandler<UpdateItemCommand> {
	private IItemRepository _repository;
	
	public UpdateItemCommandHandler (IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateItemCommand request, CancellationToken cancellationToken) {
		var item = _repository.Find(request.Item.Id);
		if(item is null) return;
		item.Update(request.Item);
		_repository.Update(request.Item);
	}
}

