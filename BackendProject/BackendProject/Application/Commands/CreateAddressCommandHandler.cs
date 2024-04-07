using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateAddressCommandHandler : ICommandHandler<CreateAddressCommand, int> {

	private readonly IAddressRepository _repository;
	
	public CreateAddressCommandHandler (IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken) {
	   var address = await _repository.Create(request.Address);
	   return address.Id;
	}
}
