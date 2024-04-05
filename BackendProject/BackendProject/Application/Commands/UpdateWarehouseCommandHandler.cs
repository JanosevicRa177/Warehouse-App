using BackendProject.Infrastructure.Interfaces;




class UpdateWarehouseCommandHandler : ICommandHandler<UpdateWarehouseCommand, Guid> {
	private IWarehouseRepository _repository;
	
	public UpdateWarehouseCommand(IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateWarehouseCommand request, CancellationToken cancellationToken) {
		Warehouse existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

