using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class DeleteAddressCommandHandler : ICommandHandler<DeleteAddressCommand> {
		private IAddressRepository _repository;
	
	public DeleteAddressCommandHandler (IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken) {
		var address = _repository.Find(request.Id);
		if(address is null) return;
		_repository.Delete(address);
	}
}
