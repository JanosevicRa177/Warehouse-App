using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public sealed record CreateUserCommand(User User) : ICommand<int>;


