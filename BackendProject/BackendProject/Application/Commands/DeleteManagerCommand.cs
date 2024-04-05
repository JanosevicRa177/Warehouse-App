using BackendProject.Application.Shared;
using BackendProject.Model.Manager;




public sealed record DeleteManagerCommand(Guid id) : ICommand;
