using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateItemCommand(UpdateItemDto UpdateItemDto, int Id) : ICommand;
