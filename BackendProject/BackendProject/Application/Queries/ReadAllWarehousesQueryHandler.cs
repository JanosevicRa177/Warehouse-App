using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadAllWarehousesQueryHandler : IQueryHandler<ReadAllWarehousesQuery, IEnumerable<Warehouse>> {

	private readonly IWarehouseRepository _repository;
	
	public ReadAllWarehousesQueryHandler (IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<Warehouse>> Handle(ReadAllWarehousesQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

