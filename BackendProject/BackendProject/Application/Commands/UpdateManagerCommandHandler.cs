using BackendProject.Infrastructure.Interfaces;




class UpdateManagerCommandHandler : ICommandHandler<UpdateManagerCommand, Guid> {
	private IManagerRepository _repository;
	
	public UpdateManagerCommand(IManagerRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateManagerCommand request, CancellationToken cancellationToken) {
		Manager existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

