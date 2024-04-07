using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;

public sealed record ReadOneAddressQuery(int Id) : IQuery<Address>;
 
