using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand> {
		private IUserRepository _repository;
	
	public DeleteUserCommandHandler (IUserRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken) {
		var user = _repository.Find(request.Id);
		if(user is null) return;
		_repository.Delete(user);
	}
}
