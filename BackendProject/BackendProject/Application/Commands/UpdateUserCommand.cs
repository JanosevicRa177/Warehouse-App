using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateUserCommand(UpdateUserDto UpdateUserDto, int Id) : ICommand;
