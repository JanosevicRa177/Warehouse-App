using BackendProject.Infrastructure.Interfaces;




class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, Guid> {
	private IUserRepository _repository;
	
	public UpdateUserCommand(IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateUserCommand request, CancellationToken cancellationToken) {
		User existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

