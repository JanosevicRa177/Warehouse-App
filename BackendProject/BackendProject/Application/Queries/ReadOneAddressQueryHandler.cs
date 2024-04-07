using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneAddressQueryHandler : IQueryHandler<ReadOneAddressQuery, Address> {

	private readonly IAddressRepository _repository;
	
	public ReadOneAddressQueryHandler(IAddressRepository repository) {
		_repository = repository;
	}
	
	public async Task<Address> Handle(ReadOneAddressQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

