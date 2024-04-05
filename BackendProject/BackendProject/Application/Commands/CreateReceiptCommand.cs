using BackendProject.Application.Shared;
using BackendProject.Model.Receipt;


public sealed record CreateReceiptCommand(Receipt obj) : ICommand<Guid>;


