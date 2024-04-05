using BackendProject.Application.Shared;
using BackendProject.Model.ReceiptItem;


public sealed record CreateReceiptItemCommand(ReceiptItem obj) : ICommand<Guid>;


