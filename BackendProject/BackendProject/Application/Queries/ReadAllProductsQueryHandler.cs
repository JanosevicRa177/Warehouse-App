using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadAllProductsQueryHandler : IQueryHandler<ReadAllProductsQuery, IEnumerable<Product>> {

	private readonly IProductRepository _repository;
	
	public ReadAllProductsQueryHandler(IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<Product>> Handle(ReadAllProductsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

