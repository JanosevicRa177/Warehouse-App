using BackendProject.Application.Shared;
using BackendProject.Model.Product;



public sealed record UpdateProductCommand(Product obj) : ICommand<Guid>;

