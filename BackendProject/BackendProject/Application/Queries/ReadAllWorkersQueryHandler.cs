using BackendProject.Infrastructure.Interfaces;


class ReadAllWorkersQueryHandler : IQueryHandler<ReadAllWorkersQuery, List<Worker>> {

	private IWorkerRepository _repository;
	
	public ReadAllWorkersQuery(IWorkerRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<Worker>> Handle(ReadAllWorkersQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

