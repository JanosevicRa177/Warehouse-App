using BackendProject.Infrastructure.Interfaces;




class UpdateItemCommandHandler : ICommandHandler<UpdateItemCommand, Guid> {
	private IItemRepository _repository;
	
	public UpdateItemCommand(IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateItemCommand request, CancellationToken cancellationToken) {
		Item existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

