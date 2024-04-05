using BackendProject.Application.Shared;
using BackendProject.Model.Item;


public sealed record CreateItemCommand(Item obj) : ICommand<Guid>;


