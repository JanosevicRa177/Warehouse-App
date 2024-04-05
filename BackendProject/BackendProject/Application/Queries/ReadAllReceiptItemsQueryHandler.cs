using BackendProject.Infrastructure.Interfaces;


class ReadAllReceiptItemsQueryHandler : IQueryHandler<ReadAllReceiptItemsQuery, List<ReceiptItem>> {

	private IReceiptItemRepository _repository;
	
	public ReadAllReceiptItemsQuery(IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<ReceiptItem>> Handle(ReadAllReceiptItemsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

