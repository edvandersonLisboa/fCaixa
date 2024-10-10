

using Flunt.Notifications;
using Shared.Commands;
using Shared.Handlers;
using Shared.ValueObjects;

namespace Application.Comands.Base
{
    public abstract class CommandHandlerBase<TCommand> : Notifiable<Notification>, ICommandHandler<TCommand> where TCommand : ICommand
    {
        public abstract Task<ICommandResult> HandleAsync(TCommand command);

        protected virtual ICollection<Error> GetErrorsFromNotifications(int errorCode)
        {
            HashSet<Error> errors = new();
            foreach (var error in Notifications)
            {
                errors.Add(new Error(errorCode, error.Message));
            }

            return errors;
        }
    }
}
