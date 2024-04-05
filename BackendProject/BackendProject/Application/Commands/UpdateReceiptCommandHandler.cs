using BackendProject.Infrastructure.Interfaces;




class UpdateReceiptCommandHandler : ICommandHandler<UpdateReceiptCommand, Guid> {
	private IReceiptRepository _repository;
	
	public UpdateReceiptCommand(IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateReceiptCommand request, CancellationToken cancellationToken) {
		Receipt existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

