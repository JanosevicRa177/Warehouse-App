using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;


public class ReadAllUsersQueryHandler : IQueryHandler<ReadAllUsersQuery, IEnumerable<User>> {

	private readonly IUserRepository _repository;
	
	public ReadAllUsersQueryHandler (IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<User>> Handle(ReadAllUsersQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

