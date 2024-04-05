using BackendProject.Application.Shared;
using BackendProject.Model.Worker;




public sealed record DeleteWorkerCommand(Guid id) : ICommand;
