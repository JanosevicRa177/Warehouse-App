using BackendProject.Infrastructure.Interfaces;


class CreateReceiptCommandHandler : ICommandHandler<CreateReceiptCommand, Guid> {

	private IReceiptRepository _repository;
	
	public CreateReceiptCommand(IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateReceiptCommand request, CancellationToken cancellationToken) {
	   Receipt obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



