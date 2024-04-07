using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public sealed record ReadAllItemsQuery() : IQuery<IEnumerable<Item>>;
 
