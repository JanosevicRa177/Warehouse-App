using BackendProject.Infrastructure.Interfaces;


class ReadAllWarehousesQueryHandler : IQueryHandler<ReadAllWarehousesQuery, List<Warehouse>> {

	private IWarehouseRepository _repository;
	
	public ReadAllWarehousesQuery(IWarehouseRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Warehouse>> Handle(ReadAllWarehousesQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

