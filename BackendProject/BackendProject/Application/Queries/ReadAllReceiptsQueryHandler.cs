using BackendProject.Infrastructure.Interfaces;


class ReadAllReceiptsQueryHandler : IQueryHandler<ReadAllReceiptsQuery, List<Receipt>> {

	private IReceiptRepository _repository;
	
	public ReadAllReceiptsQuery(IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Receipt>> Handle(ReadAllReceiptsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

