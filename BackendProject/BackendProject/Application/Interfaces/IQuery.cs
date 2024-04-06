using MediatR;

namespace BackendProject.Application.Interfaces;

public interface IQuery<out T> : IRequest<T> 
{
}