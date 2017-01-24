namespace BedBrebo.Domain.Core
{
    public interface IEventHandlerRegistry
    {
        void Register(IEventHandler handler);
    }
}