using BackendProject.Application.Shared;
using BackendProject.Model.Receipt;




public sealed record DeleteReceiptCommand(Guid id) : ICommand;
