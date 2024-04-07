using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneUserQueryHandler : IQueryHandler<ReadOneUserQuery, User> {

	private readonly IUserRepository _repository;
	
	public ReadOneUserQueryHandler(IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<User> Handle(ReadOneUserQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

