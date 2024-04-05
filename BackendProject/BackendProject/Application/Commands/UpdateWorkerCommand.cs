using BackendProject.Application.Shared;
using BackendProject.Model.Worker;



public sealed record UpdateWorkerCommand(Worker obj) : ICommand<Guid>;

