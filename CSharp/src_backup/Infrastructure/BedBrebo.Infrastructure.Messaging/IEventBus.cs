using BedBrebo.Domain.Core;

namespace BedBrebo.Infrastructure.Messaging
{
    public interface IEventBus
    {
        void Publish(IEvent @event);
    }
}