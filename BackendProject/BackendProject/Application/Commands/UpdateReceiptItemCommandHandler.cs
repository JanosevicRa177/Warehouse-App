using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class UpdateReceiptItemCommandHandler : ICommandHandler<UpdateReceiptItemCommand> {
	private IReceiptItemRepository _repository;
	
	public UpdateReceiptItemCommandHandler (IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateReceiptItemCommand request, CancellationToken cancellationToken) {
		var receiptItem = _repository.Find(request.ReceiptItem.Id);
		if(receiptItem is null) return;
		receiptItem.Update(request.ReceiptItem);
		_repository.Update(request.ReceiptItem);
	}
}
