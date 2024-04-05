using BackendProject.Infrastructure.Interfaces;





class DeleteManagerCommandHandler : ICommandHandler<DeleteManagerCommand> {
		private IManagerRepository _repository;
	
	public DeleteManagerCommand(IManagerRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteManagerCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
