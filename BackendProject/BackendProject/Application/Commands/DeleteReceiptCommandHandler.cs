using BackendProject.Infrastructure.Interfaces;





class DeleteReceiptCommandHandler : ICommandHandler<DeleteReceiptCommand> {
		private IReceiptRepository _repository;
	
	public DeleteReceiptCommand(IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteReceiptCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
