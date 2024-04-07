using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateProductCommand(UpdateProductDto UpdateProductDto, int Id) : ICommand;
