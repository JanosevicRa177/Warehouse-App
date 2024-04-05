using BackendProject.Infrastructure.Interfaces;


class ReadAllProductsQueryHandler : IQueryHandler<ReadAllProductsQuery, List<Product>> {

	private IProductRepository _repository;
	
	public ReadAllProductsQuery(IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Product>> Handle(ReadAllProductsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

