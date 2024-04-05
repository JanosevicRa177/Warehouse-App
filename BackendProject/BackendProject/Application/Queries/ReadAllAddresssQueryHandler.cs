using BackendProject.Infrastructure.Interfaces;


class ReadAllAddresssQueryHandler : IQueryHandler<ReadAllAddresssQuery, List<Address>> {

	private IAddressRepository _repository;
	
	public ReadAllAddresssQuery(IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Address>> Handle(ReadAllAddresssQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

