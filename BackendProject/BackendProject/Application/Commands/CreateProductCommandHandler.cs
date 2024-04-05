using BackendProject.Infrastructure.Interfaces;


class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid> {

	private IProductRepository _repository;
	
	public CreateProductCommand(IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken) {
	   Product obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}



