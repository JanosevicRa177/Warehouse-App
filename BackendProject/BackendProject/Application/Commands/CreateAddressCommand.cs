using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public sealed record CreateAddressCommand(Address Address) : ICommand<int>;


