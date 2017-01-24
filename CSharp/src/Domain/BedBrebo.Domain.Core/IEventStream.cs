using System;

namespace BedBrebo.Domain.Core
{
    interface IEventStream
    {
        IObservable<T> Register<T>() where T : IEvent;
    }
}