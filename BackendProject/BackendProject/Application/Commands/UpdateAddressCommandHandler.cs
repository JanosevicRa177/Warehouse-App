using BackendProject.Infrastructure.Interfaces;




class UpdateAddressCommandHandler : ICommandHandler<UpdateAddressCommand, Guid> {
	private IAddressRepository _repository;
	
	public UpdateAddressCommand(IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateAddressCommand request, CancellationToken cancellationToken) {
		Address existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

