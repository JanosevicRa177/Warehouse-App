using BackendProject.Infrastructure.Interfaces;




class UpdateWorkerCommandHandler : ICommandHandler<UpdateWorkerCommand, Guid> {
	private IWorkerRepository _repository;
	
	public UpdateWorkerCommand(IWorkerRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateWorkerCommand request, CancellationToken cancellationToken) {
		Worker existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

