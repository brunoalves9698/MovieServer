using MovieService.Domain.Commands.Core;

namespace MovieService.Domain.Handlers.Core
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
