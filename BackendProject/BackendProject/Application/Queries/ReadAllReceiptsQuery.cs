using BackendProject.Application.Shared;
using BackendProject.Model.Receipt;


public sealed record ReadAllReceiptsQuery() : IQuery<List<Receipt>>;


 
