using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, int> {

	private readonly IUserRepository _repository;
	
	public CreateUserCommandHandler (IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken) {
	   var user = await _repository.Create(request.User);
	   return user.Id;
	}
}
