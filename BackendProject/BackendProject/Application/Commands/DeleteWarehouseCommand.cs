using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public sealed record DeleteWarehouseCommand(int Id) : ICommand;
