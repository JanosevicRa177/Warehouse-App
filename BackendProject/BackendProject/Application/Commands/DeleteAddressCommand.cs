using BackendProject.Application.Shared;
using BackendProject.Model.Address;




public sealed record DeleteAddressCommand(Guid id) : ICommand;
