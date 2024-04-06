using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public sealed record UpdateProductCommand(Product Product) : ICommand;

