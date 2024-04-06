using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public sealed record CreateReceiptItemCommand(ReceiptItem ReceiptItem) : ICommand<int>;


