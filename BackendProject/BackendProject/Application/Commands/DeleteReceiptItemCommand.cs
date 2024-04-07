using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteReceiptItemCommand(int Id) : ICommand;
