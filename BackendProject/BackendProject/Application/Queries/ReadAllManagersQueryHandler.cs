using BackendProject.Infrastructure.Interfaces;


class ReadAllManagersQueryHandler : IQueryHandler<ReadAllManagersQuery, List<Manager>> {

	private IManagerRepository _repository;
	
	public ReadAllManagersQuery(IManagerRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Manager>> Handle(ReadAllManagersQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

