using BackendProject.Infrastructure.Interfaces;





class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand> {
		private IProductRepository _repository;
	
	public DeleteProductCommand(IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(DeleteProductCommand request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
