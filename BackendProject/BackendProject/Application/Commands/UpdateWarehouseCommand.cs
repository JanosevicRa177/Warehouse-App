using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateWarehouseCommand(UpdateWarehouseDto UpdateWarehouseDto, int Id) : ICommand;
