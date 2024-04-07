using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public class ReadOneReceiptItemQueryHandler : IQueryHandler<ReadOneReceiptItemQuery, ReceiptItem> {

	private readonly IReceiptItemRepository _repository;
	
	public ReadOneReceiptItemQueryHandler (IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<ReceiptItem> Handle(ReadOneReceiptItemQuery request, CancellationToken cancellationToken) {
	   return _repository.Find(request.Id)!;
	}
}

