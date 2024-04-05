using BackendProject.Application.Shared;
using BackendProject.Model.User;


public sealed record CreateUserCommand(User obj) : ICommand<Guid>;


