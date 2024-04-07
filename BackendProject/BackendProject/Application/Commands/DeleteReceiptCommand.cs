using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteReceiptCommand(int Id) : ICommand;
