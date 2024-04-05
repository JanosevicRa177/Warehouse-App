using BackendProject.Application.Shared;
using BackendProject.Model.Warehouse;



public sealed record UpdateWarehouseCommand(Warehouse obj) : ICommand<Guid>;

