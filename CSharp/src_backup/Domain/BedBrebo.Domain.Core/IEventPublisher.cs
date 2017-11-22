using System.Collections.Generic;

namespace BedBrebo.Domain.Core
{
    public interface IEventPublisher
    {
        IEnumerable<IEvent> GetChanges();
    }
}