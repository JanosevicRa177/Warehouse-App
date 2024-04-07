using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteUserCommand(int Id) : ICommand;
