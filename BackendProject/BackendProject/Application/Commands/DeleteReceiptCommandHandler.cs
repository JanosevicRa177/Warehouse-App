using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class DeleteReceiptCommandHandler : ICommandHandler<DeleteReceiptCommand> {
		private IReceiptRepository _repository;
	
	public DeleteReceiptCommandHandler (IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(DeleteReceiptCommand request, CancellationToken cancellationToken) {
		var receipt = _repository.Find(request.Id);
		if(receipt is null) return;
		_repository.Delete(receipt);
	}
}
