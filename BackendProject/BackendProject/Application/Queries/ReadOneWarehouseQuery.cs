using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public sealed record ReadOneWarehouseQuery(int Id) : IQuery<Warehouse>;
 
