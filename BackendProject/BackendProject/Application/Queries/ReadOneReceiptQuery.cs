using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public sealed record ReadOneReceiptQuery(int Id) : IQuery<Receipt>;
 
