using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public class DeleteReceiptItemCommandHandler : ICommandHandler<DeleteReceiptItemCommand> {
		private IReceiptItemRepository _repository;
	
	public DeleteReceiptItemCommandHandler (IReceiptItemRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteReceiptItemCommand request, CancellationToken cancellationToken) {
		var receiptItem = _repository.Find(request.Id);
		if(receiptItem is null) return;
		_repository.Delete(receiptItem);
	}
}
