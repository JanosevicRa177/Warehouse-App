using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand> {
	private IUserRepository _repository;
	
	public UpdateUserCommandHandler (IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken) {
		var user = _repository.Find(request.Id);
		if(user is null) return;
		user.Update(request.UpdateUserDto);
		_repository.Update(user);
	}
}
