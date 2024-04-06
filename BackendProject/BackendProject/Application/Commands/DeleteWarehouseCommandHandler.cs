using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public class DeleteWarehouseCommandHandler : ICommandHandler<DeleteWarehouseCommand> {
		private IWarehouseRepository _repository;
	
	public DeleteWarehouseCommandHandler (IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteWarehouseCommand request, CancellationToken cancellationToken) {
		var warehouse = _repository.Find(request.Id);
		if(warehouse is null) return;
		_repository.Delete(warehouse);
	}
}
