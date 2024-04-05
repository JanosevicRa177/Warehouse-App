using BackendProject.Application.Shared;
using BackendProject.Model.Receipt;



public sealed record UpdateReceiptCommand(Receipt obj) : ICommand<Guid>;

