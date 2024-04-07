using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateReceiptItemCommandHandler : ICommandHandler<CreateReceiptItemCommand, int> {

	private readonly IReceiptItemRepository _repository;
	
	public CreateReceiptItemCommandHandler (IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateReceiptItemCommand request, CancellationToken cancellationToken) {
	   var receiptItem = await _repository.Create(request.ReceiptItem);
	   return receiptItem.Id;
	}
}
