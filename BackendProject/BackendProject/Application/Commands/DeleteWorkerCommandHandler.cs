using BackendProject.Infrastructure.Interfaces;





class DeleteWorkerCommandHandler : ICommandHandler<DeleteWorkerCommand> {
		private IWorkerRepository _repository;
	
	public DeleteWorkerCommand(IWorkerRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteWorkerCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
