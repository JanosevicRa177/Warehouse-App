using BackendProject.Application.Shared;
using BackendProject.Model.Manager;



public sealed record UpdateManagerCommand(Manager obj) : ICommand<Guid>;

