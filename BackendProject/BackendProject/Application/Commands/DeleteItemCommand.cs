using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteItemCommand(int Id) : ICommand;
