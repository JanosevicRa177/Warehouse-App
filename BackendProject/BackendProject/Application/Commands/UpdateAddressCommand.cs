using BackendProject.Application.Shared;
using BackendProject.Model.Address;



public sealed record UpdateAddressCommand(Address obj) : ICommand<Guid>;

