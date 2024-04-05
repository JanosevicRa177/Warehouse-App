using BackendProject.Infrastructure.Interfaces;


class CreateItemCommandHandler : ICommandHandler<CreateItemCommand, Guid> {

	private IItemRepository _repository;
	
	public CreateItemCommand(IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateItemCommand request, CancellationToken cancellationToken) {
	   Item obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



