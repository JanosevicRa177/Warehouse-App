using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public class CreateReceiptCommandHandler : ICommandHandler<CreateReceiptCommand, int> {

	private readonly IReceiptRepository _repository;
	
	public CreateReceiptCommandHandler (IReceiptRepository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(CreateReceiptCommand request, CancellationToken cancellationToken) {
	   var receipt = await _repository.Create(request.Receipt);
	   return receipt.Id;
	}
}



