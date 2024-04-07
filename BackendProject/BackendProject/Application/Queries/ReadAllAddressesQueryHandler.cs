using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadAllAddressesQueryHandler : IQueryHandler<ReadAllAddressesQuery, IEnumerable<Address>> {

	private readonly IAddressRepository _repository;
	
	public ReadAllAddressesQueryHandler (IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<Address>> Handle(ReadAllAddressesQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

