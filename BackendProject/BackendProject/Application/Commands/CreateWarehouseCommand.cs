using BackendProject.Application.Shared;
using BackendProject.Model.Warehouse;


public sealed record CreateWarehouseCommand(Warehouse obj) : ICommand<Guid>;


