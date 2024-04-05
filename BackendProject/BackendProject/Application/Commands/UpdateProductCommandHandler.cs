using BackendProject.Infrastructure.Interfaces;




class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, Guid> {
	private IProductRepository _repository;
	
	public UpdateProductCommand(IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateProductCommand request, CancellationToken cancellationToken) {
		Product existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

