using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;


public class ReadAllReceiptItemsQueryHandler : IQueryHandler<ReadAllReceiptItemsQuery, IEnumerable<ReceiptItem>> {

	private readonly IReceiptItemRepository _repository;
	
	public ReadAllReceiptItemsQueryHandler (IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<ReceiptItem>> Handle(ReadAllReceiptItemsQuery request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}

