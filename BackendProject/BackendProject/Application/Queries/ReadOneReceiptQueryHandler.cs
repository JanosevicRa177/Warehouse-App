using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneReceiptQueryHandler : IQueryHandler<ReadOneReceiptQuery, Receipt> {

	private readonly IReceiptRepository _repository;
	
	public ReadOneReceiptQueryHandler (IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<Receipt> Handle(ReadOneReceiptQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

