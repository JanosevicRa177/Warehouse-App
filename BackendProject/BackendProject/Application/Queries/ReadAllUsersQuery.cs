using BackendProject.Application.Shared;
using BackendProject.Model.User;


public sealed record ReadAllUsersQuery() : IQuery<List<User>>;


 
