using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateWarehouseCommandHandler : ICommandHandler<CreateWarehouseCommand, int> {

	private readonly IWarehouseRepository _repository;
	
	public CreateWarehouseCommandHandler (IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateWarehouseCommand request, CancellationToken cancellationToken) {
	   var warehouse = await _repository.Create(request.Warehouse);
	   return warehouse.Id;
	}
}



