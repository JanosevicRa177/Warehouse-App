using BackendProject.Infrastructure.Interfaces;


class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Guid> {

	private IUserRepository _repository;
	
	public CreateUserCommand(IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken) {
	   User obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



