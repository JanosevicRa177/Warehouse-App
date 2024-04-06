using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;


public class ReadAllItemsQueryHandler : IQueryHandler<ReadAllItemsQuery, IEnumerable<Item>> {

	private readonly IItemRepository _repository;
	
	public ReadAllItemsQueryHandler (IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<Item>> Handle(ReadAllItemsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

