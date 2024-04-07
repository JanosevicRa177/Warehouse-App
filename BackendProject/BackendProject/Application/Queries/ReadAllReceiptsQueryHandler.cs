using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadAllReceiptsQueryHandler : IQueryHandler<ReadAllReceiptsQuery, IEnumerable<Receipt>> {

	private readonly IReceiptRepository _repository;
	
	public ReadAllReceiptsQueryHandler(IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<Receipt>> Handle(ReadAllReceiptsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

