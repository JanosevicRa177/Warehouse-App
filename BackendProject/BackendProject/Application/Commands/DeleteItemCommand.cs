using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;





public sealed record DeleteItemCommand(int Id) : ICommand;
