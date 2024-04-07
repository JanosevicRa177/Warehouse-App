using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneItemQueryHandler : IQueryHandler<ReadOneItemQuery, Item> {

	private readonly IItemRepository _repository;
	
	public ReadOneItemQueryHandler(IItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<Item> Handle(ReadOneItemQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

