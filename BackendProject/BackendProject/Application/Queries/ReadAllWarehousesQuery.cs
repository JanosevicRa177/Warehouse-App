using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public sealed record ReadAllWarehousesQuery() : IQuery<List<Warehouse>>;
 
