using BackendProject.Application.Shared;
using BackendProject.Model.User;




public sealed record DeleteUserCommand(Guid id) : ICommand;
