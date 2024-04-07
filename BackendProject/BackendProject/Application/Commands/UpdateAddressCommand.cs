using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateAddressCommand(UpdateAddressDto UpdateAddressDto, int Id) : ICommand;
