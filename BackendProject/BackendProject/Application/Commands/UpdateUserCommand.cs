using BackendProject.Application.Shared;
using BackendProject.Model.User;



public sealed record UpdateUserCommand(User obj) : ICommand<Guid>;

