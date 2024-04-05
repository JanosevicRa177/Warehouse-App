using BackendProject.Application.Shared;
using BackendProject.Model.ReceiptItem;



public sealed record UpdateReceiptItemCommand(ReceiptItem obj) : ICommand<Guid>;

