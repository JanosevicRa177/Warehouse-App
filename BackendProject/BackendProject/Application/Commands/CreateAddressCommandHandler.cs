using BackendProject.Infrastructure.Interfaces;


class CreateAddressCommandHandler : ICommandHandler<CreateAddressCommand, Guid> {

	private IAddressRepository _repository;
	
	public CreateAddressCommand(IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateAddressCommand request, CancellationToken cancellationToken) {
	   Address obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



