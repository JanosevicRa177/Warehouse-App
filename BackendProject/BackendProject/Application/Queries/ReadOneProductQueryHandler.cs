using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneProductQueryHandler : IQueryHandler<ReadOneProductQuery, Product> {

	private readonly IProductRepository _repository;
	
	public ReadOneProductQueryHandler(IProductRepository repository) {
		_repository = repository;
	}
	
	public async Task<Product> Handle(ReadOneProductQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

