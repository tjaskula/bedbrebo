namespace BedBrebo.Domain.Core
{
    public interface ICommandHandler<in T> where T: Command
    {
        void Handle(T command);
    }
}