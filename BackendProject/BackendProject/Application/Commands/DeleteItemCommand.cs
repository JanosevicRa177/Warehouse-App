using BackendProject.Application.Shared;
using BackendProject.Model.Item;




public sealed record DeleteItemCommand(Guid id) : ICommand;
