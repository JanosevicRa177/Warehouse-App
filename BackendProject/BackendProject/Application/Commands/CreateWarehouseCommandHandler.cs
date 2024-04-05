using BackendProject.Infrastructure.Interfaces;


class CreateWarehouseCommandHandler : ICommandHandler<CreateWarehouseCommand, Guid> {

	private IWarehouseRepository _repository;
	
	public CreateWarehouseCommand(IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateWarehouseCommand request, CancellationToken cancellationToken) {
	   Warehouse obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



