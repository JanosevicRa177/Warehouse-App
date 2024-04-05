using BackendProject.Infrastructure.Interfaces;


class CreateManagerCommandHandler : ICommandHandler<CreateManagerCommand, Guid> {

	private IManagerRepository _repository;
	
	public CreateManagerCommand(IManagerRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateManagerCommand request, CancellationToken cancellationToken) {
	   Manager obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



