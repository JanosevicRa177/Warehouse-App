using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;




public sealed record UpdateAddressCommand(Address Address) : ICommand;

