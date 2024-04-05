using BackendProject.Infrastructure.Interfaces;


class CreateWorkerCommandHandler : ICommandHandler<CreateWorkerCommand, Guid> {

	private IWorkerRepository _repository;
	
	public CreateWorkerCommand(IWorkerRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateWorkerCommand request, CancellationToken cancellationToken) {
	   Worker obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



