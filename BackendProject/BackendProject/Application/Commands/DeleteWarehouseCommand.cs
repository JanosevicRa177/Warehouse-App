using BackendProject.Application.Shared;
using BackendProject.Model.Warehouse;




public sealed record DeleteWarehouseCommand(Guid id) : ICommand;
