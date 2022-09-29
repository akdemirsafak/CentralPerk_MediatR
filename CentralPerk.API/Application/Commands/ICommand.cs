using MediatR;

namespace CentralPerk.API.Application.Commands;

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}