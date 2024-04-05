using BackendProject.Infrastructure.Interfaces;





class DeleteReceiptItemCommandHandler : ICommandHandler<DeleteReceiptItemCommand> {
		private IReceiptItemRepository _repository;
	
	public DeleteReceiptItemCommand(IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteReceiptItemCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
