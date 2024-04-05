using BackendProject.Application.Shared;
using BackendProject.Model.Item;


public sealed record ReadAllItemsQuery() : IQuery<List<Item>>;


 
