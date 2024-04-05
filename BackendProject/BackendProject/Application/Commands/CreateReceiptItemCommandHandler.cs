using BackendProject.Infrastructure.Interfaces;


class CreateReceiptItemCommandHandler : ICommandHandler<CreateReceiptItemCommand, Guid> {

	private IReceiptItemRepository _repository;
	
	public CreateReceiptItemCommand(IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateReceiptItemCommand request, CancellationToken cancellationToken) {
	   ReceiptItem obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



