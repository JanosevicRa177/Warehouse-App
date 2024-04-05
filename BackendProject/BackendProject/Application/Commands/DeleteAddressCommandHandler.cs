using BackendProject.Infrastructure.Interfaces;





class DeleteAddressCommandHandler : ICommandHandler<DeleteAddressCommand> {
		private IAddressRepository _repository;
	
	public DeleteAddressCommand(IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteAddressCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
