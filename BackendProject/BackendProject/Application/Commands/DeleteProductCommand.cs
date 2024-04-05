using BackendProject.Application.Shared;
using BackendProject.Model.Product;




public sealed record DeleteProductCommand(Guid id) : ICommand;
