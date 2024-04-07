using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class UpdateAddressCommandHandler : ICommandHandler<UpdateAddressCommand> {
	private IAddressRepository _repository;
	
	public UpdateAddressCommandHandler (IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken) {
		var address = _repository.Find(request.Id);
		if(address is null) return;
		address.Update(request.UpdateAddressDto);
		_repository.Update(address);
	}
}
