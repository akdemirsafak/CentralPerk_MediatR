using MediatR;

namespace CentralPerk.API.Application.Queries;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}