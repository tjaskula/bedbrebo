using System;

namespace BedBrebo.Domain.Core
{
    public interface ICommand : IIdentifier<Guid>
    {
    }
}