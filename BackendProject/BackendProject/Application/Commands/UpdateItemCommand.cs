using BackendProject.Application.Shared;
using BackendProject.Model.Item;



public sealed record UpdateItemCommand(Item obj) : ICommand<Guid>;

