using BackendProject.Infrastructure.Interfaces;




class UpdateReceiptItemCommandHandler : ICommandHandler<UpdateReceiptItemCommand, Guid> {
	private IReceiptItemRepository _repository;
	
	public UpdateReceiptItemCommand(IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(UpdateReceiptItemCommand request, CancellationToken cancellationToken) {
		ReceiptItem existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}

