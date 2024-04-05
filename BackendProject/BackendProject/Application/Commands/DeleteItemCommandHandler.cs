using BackendProject.Infrastructure.Interfaces;





class DeleteItemCommandHandler : ICommandHandler<DeleteItemCommand> {
		private IItemRepository _repository;
	
	public DeleteItemCommand(IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteItemCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
