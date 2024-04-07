using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteProductCommand(int Id) : ICommand;
