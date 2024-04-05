using BackendProject.Application.Shared;
using BackendProject.Model.Product;


public sealed record ReadAllProductsQuery() : IQuery<List<Product>>;


 
