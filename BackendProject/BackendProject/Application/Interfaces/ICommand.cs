using MediatR;

namespace BackendProject.Application.Interfaces;

public interface ICommand: IRequest {}
public interface ICommand<out TResult>: IRequest<TResult> {}