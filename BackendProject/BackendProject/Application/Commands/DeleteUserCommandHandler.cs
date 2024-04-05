using BackendProject.Infrastructure.Interfaces;





class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand> {
		private IUserRepository _repository;
	
	public DeleteUserCommand(IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteUserCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
