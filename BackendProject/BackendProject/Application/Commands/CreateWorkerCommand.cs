using BackendProject.Application.Shared;
using BackendProject.Model.Worker;


public sealed record CreateWorkerCommand(Worker obj) : ICommand<Guid>;


