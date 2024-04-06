using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;


public class ReadAllAddresssQueryHandler : IQueryHandler<ReadAllAddresssQuery, IEnumerable<Address>> {

	private readonly IAddressRepository _repository;
	
	public ReadAllAddresssQueryHandler (IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<Address>> Handle(ReadAllAddresssQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

