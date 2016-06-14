namespace BedBrebo.Domain.Core
{
    public interface IIdentifier<out T>
    {
        T GetId();
    }
}