using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteAddressCommand(int Id) : ICommand;
