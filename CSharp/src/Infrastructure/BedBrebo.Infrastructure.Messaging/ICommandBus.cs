using System;
using BedBrebo.Domain.Core;

namespace BedBrebo.Infrastructure.Messaging
{
    public interface ICommandBus
    {
        void Send(ICommand command);
        void Send(ICommand command, Action onSuccess, Action<Exception> onError = null);
    }
}