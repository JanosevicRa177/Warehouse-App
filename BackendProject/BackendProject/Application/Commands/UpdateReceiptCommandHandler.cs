using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public class UpdateReceiptCommandHandler : ICommandHandler<UpdateReceiptCommand> {
	private IReceiptRepository _repository;
	
	public UpdateReceiptCommandHandler (IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task Handle(UpdateReceiptCommand request, CancellationToken cancellationToken) {
		var receipt = _repository.Find(request.Receipt.Id);
		if(receipt is null) return;
		receipt.Update(request.Receipt);
		_repository.Update(request.Receipt);
	}
}

