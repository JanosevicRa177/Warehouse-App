using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public sealed record CreateWarehouseCommand(Warehouse Warehouse) : ICommand<int>;


