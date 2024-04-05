using BackendProject.Infrastructure.Interfaces;


class ReadAllItemsQueryHandler : IQueryHandler<ReadAllItemsQuery, List<Item>> {

	private IItemRepository _repository;
	
	public ReadAllItemsQuery(IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Item>> Handle(ReadAllItemsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

