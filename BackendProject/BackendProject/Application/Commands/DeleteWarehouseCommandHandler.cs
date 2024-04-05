using BackendProject.Infrastructure.Interfaces;





class DeleteWarehouseCommandHandler : ICommandHandler<DeleteWarehouseCommand> {
		private IWarehouseRepository _repository;
	
	public DeleteWarehouseCommand(IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteWarehouseCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
