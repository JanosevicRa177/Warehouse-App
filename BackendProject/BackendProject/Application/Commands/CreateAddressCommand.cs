using BackendProject.Application.Shared;
using BackendProject.Model.Address;


public sealed record CreateAddressCommand(Address obj) : ICommand<Guid>;


