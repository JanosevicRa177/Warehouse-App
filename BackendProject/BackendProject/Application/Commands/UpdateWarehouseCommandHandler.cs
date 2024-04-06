using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public class UpdateWarehouseCommandHandler : ICommandHandler<UpdateWarehouseCommand> {
	private IWarehouseRepository _repository;
	
	public UpdateWarehouseCommandHandler (IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateWarehouseCommand request, CancellationToken cancellationToken) {
		var warehouse = _repository.Find(request.Warehouse.Id);
		if(warehouse is null) return;
		warehouse.Update(request.Warehouse);
		_repository.Update(request.Warehouse);
	}
}

