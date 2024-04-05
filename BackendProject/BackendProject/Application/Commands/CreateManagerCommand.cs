using BackendProject.Application.Shared;
using BackendProject.Model.Manager;


public sealed record CreateManagerCommand(Manager obj) : ICommand<Guid>;


