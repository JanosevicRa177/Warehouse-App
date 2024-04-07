using BackendProject.Application.Interfaces;

namespace BackendProject.Application.Commands;

public sealed record DeleteWarehouseCommand(int Id) : ICommand;
