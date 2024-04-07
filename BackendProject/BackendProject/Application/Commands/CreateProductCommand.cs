using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public sealed record CreateProductCommand(Product Product) : ICommand<int>;
