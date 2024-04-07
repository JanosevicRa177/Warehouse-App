using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneWarehouseQueryHandler : IQueryHandler<ReadOneWarehouseQuery, Warehouse> {

	private readonly IWarehouseRepository _repository;
	
	public ReadOneWarehouseQueryHandler(IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<Warehouse> Handle(ReadOneWarehouseQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

