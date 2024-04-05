using BackendProject.Application.Shared;
using BackendProject.Model.ReceiptItem;




public sealed record DeleteReceiptItemCommand(Guid id) : ICommand;
