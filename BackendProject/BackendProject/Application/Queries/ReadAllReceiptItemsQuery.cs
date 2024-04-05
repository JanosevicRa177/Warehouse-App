using BackendProject.Application.Shared;
using BackendProject.Model.ReceiptItem;


public sealed record ReadAllReceiptItemsQuery() : IQuery<List<ReceiptItem>>;


 
