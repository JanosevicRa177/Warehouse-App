using BackendProject.Infrastructure.Interfaces;


class ReadAllUsersQueryHandler : IQueryHandler<ReadAllUsersQuery, List<User>> {

	private IUserRepository _repository;
	
	public ReadAllUsersQuery(IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<List<User>> Handle(ReadAllUsersQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

