using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public sealed record UpdateReceiptItemCommand(ReceiptItem ReceiptItem) : ICommand;

