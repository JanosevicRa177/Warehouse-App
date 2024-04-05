using BackendProject.Application.Shared;
using BackendProject.Model.Product;


public sealed record CreateProductCommand(Product obj) : ICommand<Guid>;


