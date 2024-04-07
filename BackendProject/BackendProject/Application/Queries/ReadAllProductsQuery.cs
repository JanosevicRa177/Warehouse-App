using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public sealed record ReadAllProductsQuery() : IQuery<IEnumerable<Product>>;
 
